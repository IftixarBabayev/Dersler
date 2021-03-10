using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3
{
   public static class ExtationClass
    {
        

        public static void ShowConsole (this ArrayList array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        private static int index = 0;
        private static object[] mass;

        public static int AddIftixar(this object value)
        {
            mass[index] = value;
            index++;
            return index;
        }


       

    }
}
