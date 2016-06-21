using System;

class TestEnum
{
   public static void Main()
   {
       string[] Names = Enum.GetNames(typeof(WeekDays));
       foreach(string Name in Names)
       {
           Console.WriteLine("WeekDay: {0}", Name);
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