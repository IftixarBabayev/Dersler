using System;
namespace Ders7
{
    public class Number1
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual void Show()
        {
            Console.Write($"{this.Name} {this.Surname} ");
        }



    }
    public class Worker:Number1
    {
        public byte  Salary { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine(this.Salary);
        }
    }
    
}
