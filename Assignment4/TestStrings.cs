using System;
namespace Induction
{
    class TestStrings
    {
        static void Main()
        {
            string fristName = "Radha";
            string lastName = "Bisht";
            string result = null;
            // Convert to upper case
            result = fristName.ToUpper();
            Console.WriteLine("Coverting \"{0}\" to upper case. Result is of the operation is \"{1}\".", fristName, result);

            // Convert to lower case
            result = fristName.ToLower();
            Console.WriteLine("Coverting \"{0}\" to lower case. Result of the operation is \"{1}\".", fristName, result);

            // Clone a string
            result = fristName.Clone().ToString();
            Console.WriteLine("Cloning \"{0}\" to lower case. Result of the operation is \"{1}\".", fristName, result);

            // Compare two strings
            result = fristName.CompareTo(lastName).ToString();
            Console.WriteLine("Comparing \"{0}\" with \"{1}\". Result of the operation is \"{2}\".", fristName, lastName, result);

            // Contains() Operation
            result = fristName.Contains("rad").ToString();
            Console.WriteLine("Checking \"{0}\" contains rad. Result of the operation is \"{1}\".", fristName, result);

            result = fristName.Contains("Rad").ToString();
            Console.WriteLine("Checking \"{0}\" contains Rad. Result of the operation is \"{1}\".", fristName, result);

            // EndsWith() Operation
            result = fristName.EndsWith("a").ToString();
            Console.WriteLine("Checking string \"{0}\" ends with a. Result of the operation is \"{1}\".", fristName, result);

            // Equals() Operation
            result = fristName.Equals(lastName).ToString();
            Console.WriteLine("Checking string \"{0}\" equals \"{1}\". Result of the operation is \"{2}\".", fristName, lastName, result);

            // GetHashCode() Operation
            result = fristName.GetHashCode().ToString();
            Console.WriteLine("Getting hash code of \"{0}\". Result of the operation is \"{1}\".", fristName, result);

            // GetType() Operation
            result = fristName.GetType().ToString();
            Console.WriteLine("Getting type of \"{0}\". Result of the operation is \"{1}\".", fristName, result);

            // GetTypeCode() Operation
            result = fristName.GetTypeCode().ToString();
            Console.WriteLine("Getting code of \"{0}\". Result of the operation is \"{1}\".", fristName, result);

            // indexof() operation
            result = fristName.IndexOf('d').ToString();
            Console.WriteLine("Calculating index of d in \"{0}\". Result of the operation is \"{1}\".", fristName, result);

        }
    }
}