using System;

class StringArray
{
	static void Main()
	{
        string[] welcome = GetStringArray();
        string welcomeMsg = string.Join(" ", welcome);

        Console.WriteLine(welcomeMsg);
	}

	public static string[] GetStringArray()
	{
		string[] demo = new string[3];
		demo[0] = "welcome";
		demo[1] = "to";
		demo[2] = "C#";

        return demo; 
	}
}