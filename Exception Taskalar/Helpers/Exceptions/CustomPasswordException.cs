using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Taskalar.Helpers.Exceptions
{
    public class CustomPasswordException : Exception
    {
        public CustomPasswordException()
        {
        }

        public CustomPasswordException(string msj) : base(msj)
        {

        }

    }
}
