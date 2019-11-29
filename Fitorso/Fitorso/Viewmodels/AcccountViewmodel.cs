using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Model;

namespace Fitorso.Viewmodels
{
    public class AccountViewmodel
    {
        public User User { get; set; }
        public List<MembershipType> MembershipTypes { get; set; }
    }
}
