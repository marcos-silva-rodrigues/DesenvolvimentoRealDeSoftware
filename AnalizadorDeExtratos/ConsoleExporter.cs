using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos
{
    public class ConsoleExporter : Exporter
    {
        public string Export(SummaryStatistics statistics)
        {
            var result = "the sum is " + statistics.Sum + "\n" +
            "the min is " + statistics.Min + "\n" +
            "the max is " + statistics.Max + "\n" +
            "the average is " + statistics.Average;

            return result;
        }
    }
}
