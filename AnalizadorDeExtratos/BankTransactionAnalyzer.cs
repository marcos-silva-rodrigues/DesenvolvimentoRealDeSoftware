using System.Globalization;

namespace AnalizadorDeExtratos;

public class BankTransactionAnalyzer
{
    private static readonly string RESOURCES = "../";

    public void Analyze(string filename, BankStatementParser bankStatementParser)
    {
        string[] readText = File.ReadAllLines(RESOURCES + filename);

        List<BankTransaction> bankTransactions = bankStatementParser.ParseLinesFrom(readText);
        var bankProcessor = new BankStatementProcessor(bankTransactions);

        CollectSummary(bankProcessor);
    }

    private void CollectSummary(BankStatementProcessor bankProcessor)
    {
        Console.WriteLine("the total for all transactions is " + bankProcessor.CalculateTotalAmount());
        Console.WriteLine("the total for all transactions in January is " + bankProcessor.CalculateTotalInMonth(1));
        Console.WriteLine("the total for all transactions in Jebruary is " + bankProcessor.CalculateTotalInMonth(2));
        Console.WriteLine("the total salary received is " + bankProcessor.CalculateTotalForCategory("Salary"));
    }
}