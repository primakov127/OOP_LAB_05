using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    class Printer
    {
        public virtual void IAmPrinting(Person someobj)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(someobj.GetType());
            Console.WriteLine(someobj.ToString());
            Console.WriteLine("-------------------");
        }
    }
}
