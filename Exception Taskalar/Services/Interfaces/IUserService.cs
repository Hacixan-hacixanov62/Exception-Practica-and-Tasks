using Exception_Taskalar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Taskalar.Services.Interfaces
{
    public interface  IUserService
    {
        User[] GetAll();
        public string GetByUser(User[] users, string login, string password);
        public string GetByLogin(User[] users, string login,string password);


    }
}
