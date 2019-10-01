using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class BodymassValue
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int Value { get; set; }
        public string Date { get; set; }
        public BodymassType BodymassType { get; set; }
    }
}
