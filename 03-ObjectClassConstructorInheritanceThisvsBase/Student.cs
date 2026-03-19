using System;
using System.Collections.Generic;
using System.Text;
//Əlavə Xüsusiyyətlər:
//StudentNumber - Tələbə nömrəsi(string)
//Faculty - Fakültə(string)
//GPA - Orta bal(double)
//Year - Kurs(int)
namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Student: Person
    {
        string StudentNumber;
        string Faculty;
        double GPA;
        int Year;

        public Student(string firstname, string name, string email, string id,int age, string studentNumber,
            string faculty, double gPA, int year) : base(firstname, name, email, id, age)
        {
            StudentNumber = studentNumber;
            Faculty = faculty;
            GPA = gPA;
            Year = year;
        }
        public void GetStudentInfo()
        {
            GetInfo();
            Console.WriteLine("Student number" + StudentNumber);
            Console.WriteLine("Faculty" + Faculty);
            Console.WriteLine("GPA" + GPA);
            Console.WriteLine("Year" + Year);
        }
        public int CalculateScholership()
        {
            if (GPA >= 90)
            {
                return 500;
            }
            else if (GPA >= 80)
            {
                return 350;
            }
            else if (GPA >= 70)
            {
                return 200;
            }
            else
            {
                return 0;
            }
        }
    }
}
