using System;

namespace Induction
{
    class StudentManagementSystem
    {
        int _registrationNumber;
        int _id;
        float _marks;
        static string school; 
        public string Name;

        public void DisplayInfo()
        { 
            Console.WriteLine("Name: {0}, \n Marks: {1}, \n Id: {2}, \n RegistrationNumber: {3}, \n school: {4}", Name, _marks, _id, _registrationNumber, school);
            GetGrade(_marks);
        }
        public void GetGrade(float marks)
        {
            float avg;
            avg = (marks / 1000) * 100;
            if (avg >= 85)
            {
                Console.WriteLine("Grade is A");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Grade is B");
            }
            else if (avg >= 50)
            {
                Console.WriteLine("Grade is c");
            }
            else if (avg >= 40)
            {
                Console.WriteLine("Grade is D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        public static void Main()
        {
            StudentManagementSystem s1 = new StudentManagementSystem();
            StudentManagementSystem s2 = new StudentManagementSystem();
            StudentManagementSystem s3 = new StudentManagementSystem();
            StudentManagementSystem s4 = new StudentManagementSystem();
            StudentManagementSystem s5 = new StudentManagementSystem();

            school = "DAV";
            s1._registrationNumber = 123;
            s1._id = 1;
            s1._marks = 700;
            s1.Name = "radha";
            s1.DisplayInfo();

            s2._registrationNumber = 113;
            s2._id = 11;
            s2._marks = 702;
            s2.Name = "priti";
            s2.DisplayInfo();

            s3._registrationNumber = 1123;
            s3._id = 121;
            s3._marks = 802;
            s3.Name = "swati";
            s3.DisplayInfo();

            s4._registrationNumber = 11223;
            s4._id = 1221;
            s4._marks = 992;
            s4.Name = "stuti";
            s4.DisplayInfo();

            s5._registrationNumber = 113223;
            s5._id = 12321;
            s5._marks = 92;
            s5.Name = "rekha";
            s5.DisplayInfo();
        }
    }
}
