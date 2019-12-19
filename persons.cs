using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> Persons = new List<Person>();
            
            while (true)
            {
                Console.WriteLine("Какое имя у сотрудника?");
                var FirstName = Console.ReadLine();                
                Console.WriteLine("Какая фамилия у сотрудника?");
                var LastName = Console.ReadLine(); 
                Console.WriteLine("Какой рейт?");
                var Rate = Console.ReadLine();

                var Person = new Person();

                Person.FirstName = FirstName;
                Person.LastName = LastName;
                Person.Rate = int.Parse(Rate);
                
                Persons.Add(Person);

                foreach (var item in Persons)
                {
                    item.GetInfo();
                }
            
            }
           

        }
    }

    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Rate;

        public void PrintNameSurname()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public void PrintSalary()
        {
            int Salary = ((Rate * 8)*20);
            Console.WriteLine("Salary of this guy: " + Salary);
        }

        public void GetInfo()
        {
            PrintNameSurname();
            PrintSalary();
        }

    }
}
