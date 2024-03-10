 using Exception_Taskalar.Helpers.Exceptions;
using Exception_Taskalar.Models;
using Exception_Taskalar.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Taskalar.Services
{
    public  class FactorialService:IFactorialService
    {
       

        public string FindFactorial(int? a)
        {
            int result = 1;
            try
            {
                if (a == 0)
                {
                    result = 1;
                }
                else if (a < 0)
                {
                    throw new CustomNegativeNumberException("Factorial menfi eded ola bilmez");
                }
                for (int i = 1; i <= a; i++)
                {
                    result *= i;
                }
                return result.ToString();

            }
            catch (Exception msj)
            {
                return msj.Message;
            }

        }
    }
    
}
