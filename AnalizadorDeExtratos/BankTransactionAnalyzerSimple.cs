using System.Globalization;

namespace AnalizadorDeExtratos;

public class BankTransactionAnalyzerSimple
{
    private static readonly string RESOURCES = "../";

    public static void Main(string[] args)
    {
        var filename = args[0];
        var bankStatementParser = new BankStatementCSVParser();
        string[] readText = File.ReadAllLines(RESOURCES + filename);

        List<BankTransaction> bankTransactions = bankStatementParser.ParseLinesFromCSV(readText);
        var bankProcessor = new BankStatementProcessor(bankTransactions);

        CollectSummary(bankProcessor);
    }

    public static void CollectSummary(BankStatementProcessor bankProcessor)
    {
        Console.WriteLine("the total for all transactions is " + bankProcessor.CalculateTotalAmount());
        Console.WriteLine("the total for all transactions in January is " + bankProcessor.CalculateTotalInMonth(1));
        Console.WriteLine("the total for all transactions in Jebruary is " + bankProcessor.CalculateTotalInMonth(2));
        Console.WriteLine("the total salary received is " + bankProcessor.CalculateTotalForCategory("Salary"));
    }
}