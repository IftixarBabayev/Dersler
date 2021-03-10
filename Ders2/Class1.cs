using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
   public class Class1:Class2
    {//                    buna encapsulation deyilir
        public void Show()// bir birinen toreyen classlarda iki eyni adda metodlar olsa onda onlarda biri
            //                new birini ise base olaraq gosterilmelidir
        {
            base.Show();
            Console.WriteLine("salam");
        }
    }
}
