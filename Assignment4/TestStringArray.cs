using System;

class StringArray
{
	static void Main()
	{
        string Welcome = GetStringArray();
        Console.WriteLine(Welcome);
	}

	public static string GetStringArray()
	{
		string[] demo = new string[3];
		demo[0] = "welcome";
		demo[1] = "to";
		demo[2] = "C#";

		return string.Join(" ", demo);
	}
}