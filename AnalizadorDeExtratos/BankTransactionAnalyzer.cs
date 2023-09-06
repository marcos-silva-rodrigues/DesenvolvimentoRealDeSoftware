using System.Globalization;

namespace AnalizadorDeExtratos;

public class BankTransactionAnalyzer
{
    private static readonly string RESOURCES = "../";

    public void Analyze(string filename, BankStatementParser bankStatementParser, Exporter exporter)
    {
        string[] readText = File.ReadAllLines(RESOURCES + filename);

        List<BankTransaction> bankTransactions = bankStatementParser.ParseLinesFrom(readText);
        var bankProcessor = new BankStatementProcessor(bankTransactions);
        var detail = exporter.Export(bankProcessor.SummaryTransaction());
        Console.WriteLine(detail);
    }

}