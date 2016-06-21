using System;

class TestSwitch
{
	static void Main()
	{
	    Console.WriteLine("Enter preferred choice for language.");
	    string InputChoice = Console.ReadLine().ToUpper();
	    
	    switch (InputChoice)
     	{
	        case "VB":
	            Console.WriteLine("VB .NET: OOP, multithreading and more!");
                break;	    
	        case "C#":
     	        Console.WriteLine("Good choice, C# is a fine language.");
     	        break;
	        default:
       	        Console.WriteLine("Well...good luck with that!");
       	        break;
        }
 	}
}