using Oop_Test.Base;
using Oop_Test.Childeren;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Oop_Test
{
    internal class ManagePerson
    {

        internal void TestPerson(Person person)
        {

            Console.WriteLine($"== Test {person.ClassType} ==");
            person.PrintInfo();
            person.Salery();


        }
        internal void Menu()
        {
            while (true)
            {
                Console.WriteLine($"1 . createAccount");
                Console.WriteLine($"2 . Delete");
                Console.WriteLine($"3 . Show");

                switch (Console.ReadLine())
                {
                    case "1":
                        CreateAccount();
                        break;
                        case "2":
                        DeleteAccount();
                        break;
                        case "3":
                        showall();
                            break;
                }

            }


        }
        internal void CreateAccount()
        {
            Teacher teacher = new Teacher();

            teacher.Name = "test";
            teacher.Family = "Najafi";
            teacher.Age = 40;
            teacher.City = "tehran";
            teacher.Birthday = 1984;
            teacher.Fild = "c#";


            Manager manager = new Manager()
            {
                Name = "test2",
                Family = "Jafari",
                Age = 41,
                City = "karaj",
                Birthday = 1985,
                Avdelning="C# asp.net"

            };

            Employee employee = new Employee()
            {
                Name = "test3",
                Family="joje",
                Age=39,
                City="hashgerd",
                Birthday=1986,
                Gob="C# engeniyor"

            };
            TestPerson( employee );
            TestPerson( teacher );
            TestPerson( manager );
        }
        internal void DeleteAccount()
        {
            Console.WriteLine("delete");
        }
        internal void showall() 
        {
            Console.WriteLine("Show all");
        }

    }
}
