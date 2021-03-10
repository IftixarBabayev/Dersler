using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
   public static class ExtatoinClass
    {//objectin yaratmadan cagirmaq ucun bele metodlar  istifade edilir 
        public static void Show(this object str)//bunlara extantion class lar deil ve mortezenin icine hansi tipe aid olmasi yazilir
        {
            Console.WriteLine(str);
        }

    }
}
