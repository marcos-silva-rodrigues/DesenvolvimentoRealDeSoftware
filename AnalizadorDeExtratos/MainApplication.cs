using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos
{
    public  class MainApplication
    {

        public static void Main(string[] args)
        {
            var bankTransactionAnalyzer = new BankTransactionAnalyzer();
            BankStatementParser parser = new BankStatementCSVParser();
            bankTransactionAnalyzer.Analyze(args[0], parser);
        }
    }
}
