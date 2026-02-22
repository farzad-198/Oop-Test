using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_Test
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age  { get; set; }
        public int Birthday { get; set; }
        public string City { get; set; }

        internal abstract void Salery();
        
        internal virtual void PrintInfo()
        {
            Console.WriteLine($"Name :{Name}\t Family :{Family}\t Age :{Age}\t Birthday :{Birthday}\t City :{City}");
        
        }
    }
}
