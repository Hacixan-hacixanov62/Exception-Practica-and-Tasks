

namespace Exceptions.Helpers.Exceptions
{
    internal class CustomArgumentNullException : SystemException
    {
        private readonly string? _paramName;
        private string resultMessagee;

        public CustomArgumentNullException(string msj) : base(msj)
        {

        }
        public CustomArgumentNullException(string parametr,string msj) : base(msj)
        {
            //resultMessagee = $"Parametr {parametr} , {msj}";
            _paramName = parametr;
        
        }

    }
}
