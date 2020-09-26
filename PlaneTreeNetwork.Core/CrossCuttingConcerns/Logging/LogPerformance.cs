using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Core.CrossCuttingConcerns.Logging
{
    public class LogPerformance
    {
        public string WhereClass { get; set; }
        public string WhichMethod { get; set; }
        public double TotalSeconds { get; set; }
    }

}
