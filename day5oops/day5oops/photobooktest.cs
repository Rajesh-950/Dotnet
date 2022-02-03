using System;
using System.Collections.Generic;
using System.Text;

namespace day5oops
{
    public class photobook
    {
        protected int numPages;

        public photobook()
        {
            numPages = 16;
        }

        public photobook(int numPages)
        {
            this.numPages = numPages;
        }

        public int getnumberpages()
        {
            return numPages;
        }
    }

    public class superphotobook : photobook
    {
        public superphotobook()
        {
            numPages = 64;
        }
    }
    class photobooktest
    {
        public static void Main()
        {
            photobook obj1 = new photobook();
            Console.WriteLine(obj1.getnumberpages());

            photobook obj2 = new photobook(24);
            Console.WriteLine(obj2.getnumberpages());

            superphotobook obj3 = new superphotobook();
            Console.WriteLine(obj3.getnumberpages());
        }
    }
}
