using System.Globalization;

namespace AnalizadorDeExtratos;

public class BankTransactionAnalyzer
{
       public void Analyze(Importer importer, BankStatementParser bankStatementParser, Exporter exporter)
    {
        string[] readText = importer.importer();

        List<BankTransaction> bankTransactions = bankStatementParser.ParseLinesFrom(readText);
        var bankProcessor = new BankStatementProcessor(bankTransactions);
        var detail = exporter.Export(bankProcessor.SummaryTransaction());
        Console.WriteLine(detail);
    }

}