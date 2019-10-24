using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using IDAL;
using Model;

namespace DAL
{
    public class UserContext : IUserContext
    {
        public List<User> users;
        public List<MembershipType> membershipTypes;
        public UserContext()
        {
            users = new List<User>
            {
                new User {Firstname = "Bob", Lastname = "Bouwer", Email = "Bob@Bouwers.com", Password = "Test", MembershipTypeId = 1},
                new User {Firstname = "Steve", Lastname = "Hobbs", Email = "s.Hobbs@gmail.com", Password = "Test", MembershipTypeId = 2},
                new User {Firstname = "Buck", Lastname = "Buckle", Email = "BuckBuckles@Buckle.com", Password = "Test", MembershipTypeId = 2}
            };
            membershipTypes = new List<MembershipType>
            {
                new MembershipType{Id = 1, Name = "Free"},
                new MembershipType{Id = 2, Name = "Premium"}
            };
        }

        public User GetUserByEmail(string email)
        {
            var User = users.SingleOrDefault(m => m.Email == email);
            return User;
        }

        public void RegisterUser(string email, string password)
        {
            users.Add(new User {Email = email, Password = password, MembershipTypeId = 1});
        }
    }

}
