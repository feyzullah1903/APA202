using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Person
    {
        string FirstName;
        string Name;
        string Email;
        string Id;
        int Age;
        public Person(string firstname,string name,string email,string id,int age)
        {
            this.FirstName = firstname; 
            this.Name = name;   
            this.Email = email;
            this.Id = id;   
            this.Age = age;
        }
        public string GetFullName()
        {
            return FirstName + "" + Name;
        }
        public void GetInfo()
        {
            Console.WriteLine("Full name" + GetFullName);
            Console.WriteLine("age" + Age);
            Console.WriteLine("Email"+ Email);
            Console.WriteLine(" id "+ Id);
        }
    }
    
}
