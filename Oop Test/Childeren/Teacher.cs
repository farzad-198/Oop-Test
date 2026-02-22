using System;
using System.Collections.Generic;
using System.Text;
using Oop_Test.Base;

namespace Oop_Test.Childeren
{
    internal class Teacher : Person
    {
        public string Fild { get; set; }
       

        internal override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"\t Fild :{Fild}");
        }

        internal override void Salery()
        {
            Console.WriteLine($"Teacher Salery");
        }
    }
}
