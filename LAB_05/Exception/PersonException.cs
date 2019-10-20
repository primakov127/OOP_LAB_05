using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_05
{
    class PersonException : Exception
    {
        public PersonException(string message) : base(message)
        {

        }
    }
}
