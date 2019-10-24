using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace IDAL
{
    public interface IUserContext
    {
        User GetUserByEmail(string email);
        void RegisterUser(string username, string password);
        //User ValidateUser(string username, string password);
    }
}
