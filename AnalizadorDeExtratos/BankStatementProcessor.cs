using System.Globalization;

namespace AnalizadorDeExtratos
{
    public class BankStatementProcessor
    {

        public List<BankTransaction> BankTransactions { get; private set; }

        public BankStatementProcessor(List<BankTransaction> bankTransactions)
        {
                BankTransactions = bankTransactions;
        }

        public  double CalculateTotalAmount()
        {
            double total = 0d;
            foreach (BankTransaction bankTransaction in BankTransactions)
            {
                total += bankTransaction.Amount;
            }
            return total;
        }

        public double CalculateTotalInMonth(int monthIndex)
        {
            double total = 0d;
            foreach (BankTransaction bankTransaction in BankTransactions)
            {
                if (bankTransaction.Date.Month == monthIndex)
                {
                    total += bankTransaction.Amount;
                }
            }
            return total;
        }

        public double CalculateTotalForCategory(string category)
        {
            double total = 0d;
            foreach (BankTransaction bankTransaction in BankTransactions)
            {
                if (bankTransaction.Description.Equals(category))
                {
                    total += bankTransaction.Amount;
                }
            }
            return total;
        }
    }
}