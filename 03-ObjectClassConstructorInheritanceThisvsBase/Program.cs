namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Display Teacher objects
            Teacher teacher1 = new Teacher("Said", "Nuraliyev", "SaidNuraliyev@gmail.com", "1", 30, "ItDeveloper", "Programming", 6000, 9);
            Teacher teacher2 = new Teacher("Yagmur", "Novruzov", "YagmurNovruzov@gmail.com", "2", 22, "ItDeveloper", "Programming", 1000, 2);

            // Display student objects
            Student student1 = new Student("Qombay", "Huseynov", "Qombay@gmail.com", "1", 20, "apa2025", "processing automation", 63.4, 2023);
            Student student2 = new Student("Gulcohre", "Aliyeva", "Gulcohre@gmail.com", "4", 19, "apa2026", "processing automation", 72, 2024);
            Student student3 = new Student("Qezenfer", "Huseynov", "Qezenfer@gmail.com", "5", 20, "apa2027", "processing automation", 96.8, 2025);
            Student student4 = new Student("Almaxanim", "Aliyeva", "Almaxanim@gmail.com", "6", 19, "apa2028", "processing automation", 84.7, 2026);
            // Display admin objects
            Admin admin1 = new Admin("Sirxan", "Huseynov", "sirxan@gmail.com", "1", 25, "System Administrator", "IT Department", 5);
            Admin admin2 = new Admin("Elnur", "Huseynov", "Elnur@gmail.com", "2", 28, "Network Administrator", "IT Department", 4);



            Console.WriteLine("-----STUDENTS------");


            student1.GetStudentInfo();
            student2.GetStudentInfo();
            student3.GetStudentInfo();
            student4.GetStudentInfo();


            Console.WriteLine("-----TEACHER-----");
            teacher1.ShowTeacherInfo();
            teacher2.ShowTeacherInfo();

            Console.WriteLine("------Admin-----");
            admin1.ShowAdminInfo();
            admin2.ShowAdminInfo();

            //admin telebeye icaze verir
            admin1.GrantAccess(student1);

            //statistika
            double averageGPA =
                student1.CalculateScholership() + student2.CalculateScholership() + student3.CalculateScholership() + student4.CalculateScholership();


            double TotalSalary = teacher1.CalculateSalary() + teacher2.CalculateSalary();

            Console.WriteLine("----Statistics-----");
            Console.WriteLine($"Telebeler Gpa-si{averageGPA}AZN");
            Console.WriteLine($"Muellimlerin toplam maasi{TotalSalary}AZN");


        }
    }

}
