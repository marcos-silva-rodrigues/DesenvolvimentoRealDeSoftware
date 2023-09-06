using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos
{
    public class HtmlExporter : Exporter
    {
        public String Export(SummaryStatistics statistics)
        {
            string result = "<!doctype html>";
            result += "<html lang='en'>";
            result += "<head><title>Bank Transaction Report</title></head>";
            result += "<body>";
            result += "<ul>";
            result += "<li><strong>The sum is</strong>: " + statistics.Sum + "</li>";
            result += "<li><strong>The average is</strong>: " + statistics.Average + "</li>";
            result += "<li><strong>The max is</strong>: " + statistics.Max + "</li>";
            result += "<li><strong>The min is</strong>: " + statistics.Min + "</li>";
            result += "</ul>";
            result += "</body>";
            result += "</html>";
            return result;
        }
    }
}
