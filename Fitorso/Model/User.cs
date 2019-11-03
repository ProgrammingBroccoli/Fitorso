using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Model
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public double Height { get; set; }
        public int MembershipTypeId { get; set; }
        
    }
}
