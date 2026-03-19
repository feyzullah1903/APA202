using System;
using System.Collections.Generic;
using System.Text;

//4.Administrator Sinfi
//Person-dan miras alır

//Əlavə Xüsusiyyətlər:
//Position - Vəzifə(string, məsələn: "Dekan", "Kafedra müdiri")
//Department - Kafedra / Şöbə(string)
//AccessLevel - Giriş səviyyəsi(int, 1 - 5 arası)

//Constructor:
//base keyword istifadə edin

//Metodlar:
//ShowAdminInfo() - İdarəçi məlumatlarını göstərir
//GrantAccess(Student student) - Tələbəyə sistem girişi verir (console mesajı çap edir)

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Admin:Person
    {
        string Position;
        string Department;
        int AccessLevel;

        public Admin(string firstname, string name, string email, string id, int age, string position,
         string department, int accesslevel) : base(firstname, name, email, id, age)
        {
           this.Position = position;
           this.Department = department;
           this.AccessLevel = accesslevel;

        }
        public void ShowAdminInfo()
        {
            GetInfo();
            Console.WriteLine("Position" + Position);
            Console.WriteLine("Department" + Department);
            Console.WriteLine("Access level" + AccessLevel);
        }
        public void GrantAccess(Student student)
        {
            Console.WriteLine($"Admin {GetFullName()} granted access to student {student.GetFullName()}");
        }
    }
}
