using System;

class StringArray
{
	static void Main()
	{
        string[] Welcome = GetStringArray();
        string WelcomeMsg = string.Join(" ", Welcome);

        Console.WriteLine(WelcomeMsg);
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