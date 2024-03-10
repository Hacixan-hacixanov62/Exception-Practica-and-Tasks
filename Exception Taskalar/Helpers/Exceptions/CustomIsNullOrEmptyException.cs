using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Taskalar.Helpers.Exceptions
{
    public  class CustomIsNullOrEmptyException : Exception
    { 

        public CustomIsNullOrEmptyException(string msj) : base(msj)
        {
            
        }
    }
}
