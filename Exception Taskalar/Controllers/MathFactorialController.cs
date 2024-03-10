using Exception_Taskalar.Services;
using Exception_Taskalar.Services.Interfaces;

namespace Exception_Taskalar.Controllers
{
    public  class MathFactorialController
    {
        private readonly IFactorialService _factorialService;

        public MathFactorialController()
        {
            _factorialService=new FactorialService();
        }

        public void FindFactorial()
        {
            Console.WriteLine("Add number");
            int a=int.Parse(Console.ReadLine());

            Console.WriteLine(_factorialService.FindFactorial(a));
        }

    }
}
