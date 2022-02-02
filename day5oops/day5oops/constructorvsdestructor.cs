using System;
using System.Collections.Generic;
using System.Text;

namespace day5oops
{
    public class SampleC
    {
        
        int a, b;
        //Default Constructor
        public SampleC()
        {

        }
        ~SampleC()
        {

        }
        //parametrized constructor
        public SampleC(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

    }
    class constructorvsdestructor
    {
        static void Main5(string[] args)
        {
            SampleC ObjSampleC = new SampleC();
            Console.ReadLine();
        }
    }
}
