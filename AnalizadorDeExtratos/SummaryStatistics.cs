using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos
{
    public  class SummaryStatistics
    {
        public double Max { get; private set; }
        public double Sum { get; private set; }
        public double Min { get; private set; }
        public double Average { get; private set; }

        public SummaryStatistics(double max, double min, double average, double sum)
        {
            Average = average;
            Min = min;
            Sum = sum;
            Max = max;
        }
    }
}
