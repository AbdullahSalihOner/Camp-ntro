using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> {"engin","salih","hacı","mehmet" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("ilker");
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[4]);
        }
    }
}
