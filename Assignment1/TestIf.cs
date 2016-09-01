using System;

class TestIf
{
	static void Main()
	{
	    Console.WriteLine("Enter preferred choice for language.");
	    string inputChoice = Console.ReadLine().ToUpper();
	    
	    if (inputChoice == "VB")
	    {
	        Console.WriteLine("VB .NET: OOP, multithreading and more!");
	    }
	    else if (inputChoice == "C#")
	    {
	        Console.WriteLine("Good choice, C# is a fine language.");
	    }
	    else
	    {
	        Console.WriteLine("Well...good luck with that!");
	    }
	}
}