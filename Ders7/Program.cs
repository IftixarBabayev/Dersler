using System;
using static System.Console;

namespace Ders7
{
    class Program
    {
        static void Main(string[] args)
        {
            Number1 Iftixar = new Number1 { Name = "Iftixar", Surname = "Babayev" };
            Iftixar.Show();

            WriteLine("***************************************");
            Worker Resul = new Worker { Name = "Resul", Surname = "Babayev", Salary = 250 };
            Resul.Show();


        }
    }
}
