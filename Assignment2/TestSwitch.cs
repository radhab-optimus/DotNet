using System;

class TestSwitch
{
	static void Main()
	{
	    Console.WriteLine("Enter preferred choice for language.");
	    string inputChoice = Console.ReadLine().ToUpper();
	    
	    switch (inputChoice)
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