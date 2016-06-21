using System;
namespace Induction
{
    class TestStrings
    {
        static void Main()
        {
            string FristName = "Radha";
            string LastName = "Bisht";
            string Result = null;
            // Convert to upper case
            Result = FristName.ToUpper();
            Console.WriteLine("Coverting \"{0}\" to upper case. Result is of the operation is \"{1}\".", FristName, Result);

            // Convert to lower case
            Result = FristName.ToLower();
            Console.WriteLine("Coverting \"{0}\" to lower case. Result of the operation is \"{1}\".", FristName, Result);

            // Clone a string
            Result = FristName.Clone().ToString();
            Console.WriteLine("Cloning \"{0}\" to lower case. Result of the operation is \"{1}\".", FristName, Result);

            // Compare two strings
            Result = FristName.CompareTo(LastName).ToString();
            Console.WriteLine("Comparing \"{0}\" with \"{1}\". Result of the operation is \"{2}\".", FristName, LastName, Result);

            // Contains() Operation
            Result = FristName.Contains("rad").ToString();
            Console.WriteLine("Checking \"{0}\" contains rad. Result of the operation is \"{1}\".", FristName, Result);

            Result = FristName.Contains("Rad").ToString();
            Console.WriteLine("Checking \"{0}\" contains Rad. Result of the operation is \"{1}\".", FristName, Result);

            // EndsWith() Operation
            Result = FristName.EndsWith("a").ToString();
            Console.WriteLine("Checking string \"{0}\" ends with a. Result of the operation is \"{1}\".", FristName, Result);

            // Equals() Operation
            Result = FristName.Equals(LastName).ToString();
            Console.WriteLine("Checking string \"{0}\" equals \"{1}\". Result of the operation is \"{2}\".", FristName, LastName, Result);

            // GetHashCode() Operation
            Result = FristName.GetHashCode().ToString();
            Console.WriteLine("Getting hash code of \"{0}\". Result of the operation is \"{1}\".", FristName, Result);

            // GetType() Operation
            Result = FristName.GetType().ToString();
            Console.WriteLine("Getting type of \"{0}\". Result of the operation is \"{1}\".", FristName, Result);

            // GetTypeCode() Operation
            Result = FristName.GetTypeCode().ToString();
            Console.WriteLine("Getting code of \"{0}\". Result of the operation is \"{1}\".", FristName, Result);

            // indexof() operation
            Result = FristName.IndexOf('d').ToString();
            Console.WriteLine("Calculating index of d in \"{0}\". Result of the operation is \"{1}\".", FristName, Result);

        }
    }
}