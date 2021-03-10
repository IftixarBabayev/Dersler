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
            list.AddIftixar();
            


            MyArrayList arrayList = new MyArrayList(3);
            arrayList.Add("salam");
            arrayList.Add("Iftixar");
            arrayList.Add("Babayev");
            


        }
    }
}
