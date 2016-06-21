using System;

class TestIf
{
	static void Main()
	{
	    Console.WriteLine("Enter preferred choice for language.");
	    string InputChoice = Console.ReadLine().ToUpper();
	    
	    if (InputChoice == "VB")
	    {
	        Console.WriteLine("VB .NET: OOP, multithreading and more!");
	    }
	    else if (InputChoice == "C#")
	    {
	        Console.WriteLine("Good choice, C# is a fine language.");
	    }
	    else
	    {
	        Console.WriteLine("Well...good luck with that!");
	    }
	}
}