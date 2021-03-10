using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3
{
   public  class MyArrayList
    {


        private object[] mass;
        private int index;

        public MyArrayList(int cap)  
        {
            mass = new object[cap] ;
            index = 0;
        }
        
        public int Add(object value)
        {
            
            mass[index] = value;
            index++;
            return index;
        }
        public void ShowMyArrayLst()
        {
            foreach (var item in mass)
            {
                Console.WriteLine(item);
            }
        }
        public int MyCount
        {

            get
            {
                int count = 0;
                foreach (var item in mass)
                {
                    if (mass != null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
