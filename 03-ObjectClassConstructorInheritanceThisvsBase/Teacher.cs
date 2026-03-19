using System;
using System.Collections.Generic;
using System.Text;
//Əlavə Xüsusiyyətlər:
//Department - Kafedra(string)
//MainSubject - Əsas fənn(string)
//BaseSalary - Baza maaş(decimal)
//ExperienceYears - Təcrübə ili(int)

//Constructor:
//base keyword istifadə edin
//this keyword ilə sahələri təyin edin

//Metodlar:
//ShowTeacherInfo() - Müəllim məlumatlarını göstərir
//CalculateSalary() - Maaş hesablayır:
//Baza maaş + (Təcrübə × 50 AZN)
//Məsələn: 800 + (10 × 50) = 1300 AZN

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Teacher: Person
    {
        string Department;
        string MainSubject;
        decimal BaseSalary;
        int ExperienceYears;
        public Teacher(string firstname, string name, string email, string id, int age,
            string department, string mainSubject, decimal baseSalary, int experienceYears) : base(firstname, name, email, id, age)
        {
            Department = department;
            MainSubject = mainSubject;
            BaseSalary = baseSalary;
            ExperienceYears = experienceYears;
        }
        public void ShowTeacherInfo()
        {
            GetInfo();
            Console.WriteLine("Department" + Department);
            Console.WriteLine("Main subject" + MainSubject);
            Console.WriteLine("Base salary" + BaseSalary);
            Console.WriteLine("Experience years" + ExperienceYears);
        }
        public int CalculateSalary()
        {
            return (int)(BaseSalary + (ExperienceYears * 50));
        }
    }
}
