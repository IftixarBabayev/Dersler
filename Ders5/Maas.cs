using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5
{
    public class Maas:Info
    {
        public int Salary { get; set; }
        public override void Show()
        {
            base.Show();
            Console.Write(this.Salary);
        }
    }
}
