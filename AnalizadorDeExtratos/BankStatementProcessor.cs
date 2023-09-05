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

        public double CalculateMinAmount()
        {
            double min = 0d;
            foreach (BankTransaction bankTransaction in BankTransactions)
            {
                if (bankTransaction.Amount < min)
                {
                    min = bankTransaction.Amount;
                }
            }
            return min;
        }

        public double CalculateMinAmount(Period period)
        {
            double min = 0d;
            foreach (BankTransaction bankTransaction in BankTransactions)
            {
                if (bankTransaction.Amount < min && period.Range(bankTransaction.Date))
                {
                    min = bankTransaction.Amount;
                }
            }
            return min;
        }

        public double CalculateMaxAmount()
        {
            double max = 0d;
            foreach (BankTransaction bankTransaction in BankTransactions)
            {
                if (bankTransaction.Amount > max)
                {
                    max = bankTransaction.Amount;
                }
            }
            return max;
        }

        public double CalculateMaxAmount(Period period)
        {
            double max = 0d;
            foreach (BankTransaction bankTransaction in BankTransactions)
            {
                if (bankTransaction.Amount > max && period.Range(bankTransaction.Date))
                {
                    max = bankTransaction.Amount;
        
                }
            }
            return max;
        }
    }
}