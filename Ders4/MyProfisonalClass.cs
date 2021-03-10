using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ders4
{
   public static class MyProfisonalClass
    {
        public static int MyCount(this ArrayList arrayList)
        {
            int index = 0;
            for (int i = 0; i <arrayList.Count; i++)
            {
                if (arrayList[i]!=null)
                {
                    index++;
                }
                
            }
            return index;
        }




    }
}
