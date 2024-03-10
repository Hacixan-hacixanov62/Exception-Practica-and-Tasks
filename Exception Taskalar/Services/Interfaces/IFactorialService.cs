using Exception_Taskalar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Taskalar.Services.Interfaces
{
    public interface IFactorialService
    {
        public string FindFactorial(int? a);
    }
}
