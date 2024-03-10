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
    public class UserService : IUserService
    {
        public User[] GetAll()
        {

            User user1 = new()
            {
                Id = 1,
                Name = "Test",
                Surname = "Copy1",
                Age = 10,
                Email = "test@gmail1.com ",
                Password = "12345t6"

            };

            User user2 = new()
            {
            
                Id = 2,
                Name = "Test2",
                Surname = "Copy2",
                Age = 20,
                Email = "test@gmail2.com ",
                Password = "123456"


            };

            User user3 = new()
            {

                Id = 3,
                Name = "Test3",
                Surname = "Copy3",
                Age = 30,
                Email = "test@gmail3.com ",
                Password = "123456"

            };

            return new User[] { user1, user2, user3 };
        
        }

        public string GetByUser(User[] users, string email, string password)
        {
            try
            {
                var result = users.FirstOrDefault(m => m.Email == email || m.Password == password);
                if (result != null)
                {
                    return "Userfound";
                }
                else
                {
                    throw new CustomIsNullOrEmptyException("Data not found");
                }

            }
            catch (Exception msj)
            {
                return msj.Message;
            }

        }
        public string GetByLogin(User[] users, string login, string password)
        {
            try
            {
                var result = users.FirstOrDefault(m=>m.Password == password);
                if (password.Length < 6)
                {
                    throw new CustomPasswordException("Passwordun simvolllarin sayi 6 kicik ola bilmez !");
                }
                else
                {
                    return "Password correct";
                }

            }
            catch (Exception msj) 
            {
                return msj.Message;
            }
        }






    }
}
