using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;

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
        CalculateTotalAmount(bankTransactions);
        SelectInMonth(bankTransactions, 2);
        


    }

    public static void CalculateTotalAmount(List<BankTransaction> bankTransactions)
    {
        double total = 0d;
        foreach (BankTransaction bankTransaction in bankTransactions)
        {
            total += bankTransaction.Amount;
        }

        Console.WriteLine("the total for all transactions is " + total);
    }

    public static void SelectInMonth(List<BankTransaction> bankTransactions, int monthIndex)
    {
        double total = 0d;
        foreach (BankTransaction bankTransaction in bankTransactions)
        {
            if (bankTransaction.Date.Month == monthIndex)
            {
                total += bankTransaction.Amount;
            }
        }

        Console.WriteLine($"the total for all transactions in {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthIndex)} is {total}");
    }
}