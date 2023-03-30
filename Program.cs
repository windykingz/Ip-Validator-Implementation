using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(Program.isIPV4("211.134.255.21"));
		
	}
	
	public static bool isIPV4(string ip) {
		
    if (String.IsNullOrWhiteSpace(ip))
    {
        return false;
    }
		
		string[] eachString = ip.Split('.');
		
		if (eachString.Length != 4)
			return false;
		
		byte compareWithByte;
		
		for (int i = 0; i < eachString.Length; i++) {
			//  check if each does have more than 1 chars and first is leading zero or not
			if (eachString[i].Length >= 2 && eachString[i].Substring(0, 1).Equals("0"))
				return false;
			
			// compare value byte 256
			if (!byte.TryParse(eachString[i], out compareWithByte)) 
				return false;
		}

        return true;
	}
}