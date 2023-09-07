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
            var fielImporter = new FileImporter(args[0]);
            var bankTransactionAnalyzer = new BankTransactionAnalyzer();
            BankStatementParser parser = new BankStatementCSVParser();
            Exporter exporter = new ConsoleExporter();
            bankTransactionAnalyzer.Analyze(fielImporter, parser, exporter);
        }
    }
}
