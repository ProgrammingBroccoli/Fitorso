using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BodyMassValue
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Value { get; set; }
        public string Date { get; set; }
        public int BodymassTypeId { get; set; }
    }
}
