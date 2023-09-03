using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos
{
    public interface BankStatementParser
    {
        BankTransaction ParseFrom(string line);
        List<BankTransaction> ParseLinesFrom(string[] lines);
    }
}
