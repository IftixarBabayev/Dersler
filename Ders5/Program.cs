using System;

namespace Ders5
{
    class Program
    {
        static void Main(string[] args)
        {
            Maas myInfo = new Maas();
            myInfo.Name = "Iftixar";
            myInfo.Surname = "Babayev";
            myInfo.Salary = 0x113;

            myInfo.Show();
            


        }
    }
}
