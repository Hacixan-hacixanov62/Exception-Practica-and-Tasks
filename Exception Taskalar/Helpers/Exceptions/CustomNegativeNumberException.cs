using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Taskalar.Helpers.Exceptions
{
    public class CustomNegativeNumberException:Exception

    {
        public CustomNegativeNumberException(string msj):base(msj)
        {

        }

    }
}
