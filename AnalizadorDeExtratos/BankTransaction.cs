namespace AnalizadorDeExtratos
{
    public  class BankTransaction
    {

        public DateTime Date { get; private set; }
        public double Amount { get; private set; }
        public string Description { get; private set; }

        public BankTransaction(DateTime date, double amount, string description)
        {
            Date = date;
            Amount = amount;
            Description = description;
        }

        public override string ToString()
        {
            return "BankTransaction{" +
                "date=" + Date +
                ", amount=" + Amount +
                ", description=" + Description +
                "}";
        }

        public override bool Equals(object? obj)
        {
            return obj is BankTransaction transaction &&
                   Date == transaction.Date &&
                   Amount == transaction.Amount &&
                   Description == transaction.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Date, Amount, Description);
        }
    }
}