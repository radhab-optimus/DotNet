using System;

class TestEnum
{
   public static void Main()
   {
       string[] names = Enum.GetNames(typeof(WeekDays));
       foreach(string name in names)
       {
           Console.WriteLine("WeekDay: {0}", name);
       }
   }
}

public enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Staturday,
    Sunday
}