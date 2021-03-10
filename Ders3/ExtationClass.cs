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
        private static int index ;
        private static object[] mass;
        public static void Capasite(this object arraylist, int cap)
        {
            mass = new object[cap];
            index = 0;
            
        }
        public static int AddIftixar(this object array,object value)
        {
            mass[index] = value;
            index++;
            return index;
        }


       

    }
}
