using Oop_Test.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_Test.Childeren
{
    internal class Employee : Person
    {
        public string Gob { get; set; }
        internal override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"\t Gob :{Gob}");
        }

        internal override void Salery()
        {
            Console.WriteLine($"Employee Salery");
        }
    }
}
