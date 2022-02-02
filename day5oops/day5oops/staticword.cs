using System;
using System.Collections.Generic;
using System.Text;

namespace day5oops
{
    class StaticSample
    {
        static StaticSample()
        {

        }
        public static string a = "Sample";
    }
    class staticword
    {
        static void Main4(string[] args)
        {
            StaticSample staticSample = new StaticSample();
            StaticSample.a = "3";

            Console.WriteLine(StaticSample.a);

        }
    }
}
