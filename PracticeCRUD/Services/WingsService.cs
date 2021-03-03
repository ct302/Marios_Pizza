using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.Services
{
    public class WingsService
    {

        public double SixWingCount{ get; set; } = 7.99;
        public double TwelveWingCount { get; set; } = 14.99;
        public double TwentyFourWingCount { get; set; } = 18.99;
        public double ThirtySixWingCount { get; set; } = 27.99;

        public string WingCount { get; set; }
        public double FinalWingPrice { get; set; }

    }
}
