using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vars_boxing_unboxing_
{
    class Program
    {
        static void Main(string[] args)
        {
            //kutulama-boxing
            int i = 23;
            object o = (object)i; // explicit boxing 

            //kutudan çıkarma-unboxing
            i *= 2; //i=i*2;
            i = (int)o; // bu işem "cast" işlemi

            Console.WriteLine("deger turu: {0}", i);
            Console.WriteLine("referans turu: {0}", o);

        }
    }
}
