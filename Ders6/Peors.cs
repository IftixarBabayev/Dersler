using System;
using System.Collections.Generic;
using System.Text;

namespace Ders6
{
    public class Peors
    {
        private string Name { get; set; }
       private string Surname { get; set; }
        public Peors(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public static void  Show()
        {
            Console.WriteLine();
        }

    }
}
