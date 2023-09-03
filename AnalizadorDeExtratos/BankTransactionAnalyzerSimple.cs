using System.ComponentModel;
using System.IO;

namespace AnalizadorDeExtratos;

public class BankTransactionAnalyzerSimple
{
    private static readonly string RESOURCES = "../";

    public static void Main(string[] args)
    {
        string[] readText = File.ReadAllLines(RESOURCES + args[0]);
        GetTotalTransactions(readText);
        GetTotalTransactionsForJanuary(readText);


    }

    public static void GetTotalTransactions(string[] file)
    {
        double total = 0d;
        foreach (string lines in file)
        {
            string[] columns = lines.Split(',');
            double amount = Convert.ToDouble(columns[1]);
            DateTime date = Convert.ToDateTime(columns[0]);
            total += amount;
        }

        Console.WriteLine("the total for all transactions is " + total);
    }

    public static void GetTotalTransactionsForJanuary(string[] file)
    {
        double total = 0d;
        foreach (string lines in file)
        {
            string[] columns = lines.Split(',');
            double amount = Convert.ToDouble(columns[1]);
            DateTime date = Convert.ToDateTime(columns[0]);

            if (date.Month == 1 )
            total += amount;
            {

            }
        }

        Console.WriteLine("the total for all transactions in january is " + total);
    }
}