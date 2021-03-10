using System;
using System.Collections;

namespace Ders4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            int[] mass = new int[] { 3, 4, 6, 4 };
            array.AddRange(mass);
            array.Add("salam");
            array.Add("dskahdf");
            
            Console.WriteLine(array.MyCount());
            int a=array.MyCount();

        }
    }
}
