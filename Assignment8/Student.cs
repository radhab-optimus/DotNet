using System;

namespace Induction
{
    class StudentInfo
    {
        static void Main()
        {
            Console.WriteLine("Enter students FirsName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter student's LastName");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter students age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter gender");
            string gender = Console.ReadLine();

            Student S1 = new Student(firstName, lastName, age, gender);
            S1.Print();

            //using overloaded print
            S1.Print(Student.StudentDetails.FirstName);
        }
    }
    class Student
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _gender;

        public Student(string firstName, string lastName, int age, string gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _gender = gender;
        }

        public int StudentEnrolmentNo()
        {
            Random enrollmentNo = new Random();
            int Number = enrollmentNo.Next();
            return Number;
        }

        public void Print()
        {
            int enrollmentNo = StudentEnrolmentNo();
            Console.WriteLine("welcome {0}", _firstName);
            Console.WriteLine("Student's Name is {0} {1}, \n Age: {2}, \n Gender: {3}, \n EnrollmentNo : {4}", _firstName, _lastName, _age, _gender, enrollmentNo);
        }

        public enum StudentDetails
        {
            FirstName,
            LastName,
            Age,
            Gender,
            EnrollmentNo,
        }

        // Overloading Print
        public void Print(StudentDetails detail)
        {
            switch (detail)
            {
                case StudentDetails.FirstName:
                    Console.WriteLine("FirstName of student is: {0}", _firstName);
                    break;
                case StudentDetails.LastName:
                    Console.WriteLine("LastName of student is {0}", _lastName);
                    break;
                case StudentDetails.Age:
                    Console.WriteLine("Age of the student is {0}", _age);
                    break;
                case StudentDetails.Gender:
                    Console.WriteLine("Gender of the student is {0}", _gender);
                    break;
            }
        }
    }
}
