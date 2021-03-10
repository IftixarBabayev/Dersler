using System;
using System.Collections;

namespace Ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();// Arraylistler adi arraylerden ferqli olaraq
                                             // object tipinde bir arqumen qaytarir ver uzunlugu yoxdur 
            list.Add("Iftixar");// hem string
            list.Add(24);//hem int 
            list.Add("Babayev");
            list.Add(true);//hem bool tiplerinde yeni butun tiplerde ddeyer ala bilir ve
            //adi arrayden ferqli olaraq uzunluqlari olmur

            list.ShowConsole();
            Console.WriteLine(list.Count) ;

            list.Capasite(6);
            list.AddIftixar("salam");
            list.AddIftixar(24);
            list.AddIftixar(36);
            list.ShowConsole();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**********************************");

            MyArrayList arrayList = new MyArrayList(3);
            arrayList.Add("salam");
            arrayList.Add("Iftixar");
            arrayList.Add("Babayev");
            arrayList.AddIftixar("salam");
            arrayList.ShowMyArrayLst();
            



        }
    }
}
