using System;

namespace Induction
{
    public class StudentBase
    {
        public string Name { set; get; }
        public void Display(string name, int rollNo, int age)
        {
            Console.WriteLine("Name is {0}, \n RollNo. is {1}, \n age is {2}", name, rollNo, age);
        }
    }
    public class SchoolSudent : StudentBase
    {
        int _schoolRegistrationNumber = 111232;
        public void DisplayDetails(int className)
        {
            Console.WriteLine("School registration number is {0}", _schoolRegistrationNumber);
            Console.WriteLine("Class is {0}th", className);
        }
    }
    public class CollegeSudent : StudentBase
    {
        int _universityNumber = 122323775;
        public void DisplayDetail(int semester)
        {
            Console.WriteLine("univeristy number is {0}", _universityNumber);
            Console.WriteLine("Semester is {0}", semester);
        }
    }
    public class Inheritance
    {
        public static void Main()
        {
            SchoolSudent studentObj = new SchoolSudent();
            studentObj.Name = "Radha";
            studentObj.Display(studentObj.Name, 11, 23);
            studentObj.DisplayDetails(10);

            CollegeSudent collegeObj = new CollegeSudent();
            collegeObj.Display("Ankit", 123, 22);
            collegeObj.DisplayDetail(2);
        }
    }
}
