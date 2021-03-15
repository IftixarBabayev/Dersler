using System;
using System.Collections.Generic;
using System.Text;

namespace Ders9.Core
{
    public static class Main
    {
        private static int Index = 0;
       

       
        public static void ProductsValue(this  ProductsData data,string Name,string Surname, string Catagory)
        {
            ProductsData data1 = new ProductsData { Name = Name, Surname = Surname, Catagory = Catagory };
            Index++;
            data1.Id++;

        }



    }
}
