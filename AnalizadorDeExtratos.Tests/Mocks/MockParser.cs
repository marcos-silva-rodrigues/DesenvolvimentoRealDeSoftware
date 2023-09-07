using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos.Tests.Mocks
{
    public class MockParser : BankStatementParser
    {
        public BankTransaction ParseFrom(string line)
        {
            return new BankTransaction(new DateTime(2023, 09, 07), 1500, "Freelance");
        }

        public List<BankTransaction> ParseLinesFrom(string[] lines)
        {
            return new List<BankTransaction>()
            {
                ParseFrom("")
            };
        }
    }
}
