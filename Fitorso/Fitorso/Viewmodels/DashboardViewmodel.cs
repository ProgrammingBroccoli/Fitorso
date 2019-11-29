using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace Fitorso.Viewmodels
{
    public class DashboardViewmodel
    {
        public User User { get; set; }
        public double Weight { get; set; }
        public double FatPercentage { get; set; }
        public double Bmi { get; set; }
        public double Height { get; set; }
        public string Quote { get; set; }

    }
}
