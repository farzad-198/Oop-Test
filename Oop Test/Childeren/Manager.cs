using Oop_Test.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oop_Test.Childeren
{
    internal class Manager : Person
    {
        public string Avdelning { get; set; }
        internal override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"\t Avdelning :{Avdelning}");
        }

        internal override void Salery()
        {
            Console.WriteLine($"Manager Salery");
        }
    }
}
