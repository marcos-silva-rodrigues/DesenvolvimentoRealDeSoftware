using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos
{
    public interface Exporter
    {
        string Export(SummaryStatistics statistics);
    }
}
