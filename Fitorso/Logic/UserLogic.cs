using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;

namespace Logic
{
    public class UserLogic
    {
        public UserContext _Context;

        public UserLogic()
        {
            _Context = new UserContext();
        }

        public void RegisterUser(string email, string password)
        {
            _Context.RegisterUser(email, password);
        }

        public User GetUserByEmail(string email)
        {
            var User = _Context.GetUserByEmail(email);
            return User;
        }

        public User ValidateUser(string email, string password)
        {
            var user = _Context.GetUserByEmail(email);
            if (user.Password == password)
            {
                return user;
            }

            return null;
            
        }
    }
}
