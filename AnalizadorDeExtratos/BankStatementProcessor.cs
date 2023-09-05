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
            return BankTransactions.Aggregate(0d, (acc, bankTransaction) =>  acc + bankTransaction.Amount);
        }

        public double CalculateTotalInMonth(int monthIndex)
        {
            return BankTransactions
                .Where(bankTransaction => bankTransaction.Date.Month == monthIndex)
                .Aggregate(0d, (acc, bankTransaction) => acc + bankTransaction.Amount);
        }

        public double CalculateTotalForCategory(string category)
        {
            return BankTransactions
                .Where(bankTransaction => bankTransaction.Description.Equals(category))
                .Aggregate(0d, (acc, bankTransaction) => acc + bankTransaction.Amount);
        }

        public double CalculateMinAmount()
        {
            return BankTransactions.Min(bankTransaction => bankTransaction.Amount);
        }

        public double CalculateMinAmount(Period period)
        {
            return BankTransactions
                .Where(bankTransaction => period.Range(bankTransaction.Date))
                .Min(bankTransaction => bankTransaction.Amount);
        }

        public double CalculateMaxAmount()
        {
            return BankTransactions.Max(bankTransaction => bankTransaction.Amount);
        }

        public double CalculateMaxAmount(Period period)
        {
            return BankTransactions
                .Where(bankTransaction => period.Range(bankTransaction.Date))
                .Max(bankTransaction => bankTransaction.Amount);
        }

        public List<BankTransaction> FindTransaction(Func<BankTransaction, bool> predicate)
        {
            return BankTransactions.Where(predicate).ToList();   
        }
    }
}