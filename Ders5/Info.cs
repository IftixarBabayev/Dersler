using System;
namespace Ders5
{
    public class Info
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"{this.Name} {this.Surname}");
        }


    }
}
