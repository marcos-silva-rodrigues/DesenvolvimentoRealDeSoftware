namespace AnalizadorDeExtratos.Tests
{
    public class BankStatementCSVParserTest
    {

        private BankStatementParser parser;

        public BankStatementCSVParserTest()
        {
            parser = new BankStatementCSVParser();
        }

        [Theory]
        [InlineData("30-01-2017", -50, "Tesco")]
        [InlineData("01-02-2017", -40, "Cinema")]
        [InlineData("05-02-2017", 6000, "Salary")]
        public void ShouldParseONeLineCorrectLine(string date, double amount, string category)
        {
            string line = $"{date},{amount},{category}";
            BankTransaction result = parser.ParseFrom(line);
            BankTransaction expected = new BankTransaction(Convert.ToDateTime(date), amount, category);
            Assert.Equal(expected.Date, result.Date);
            Assert.Equal(expected.Amount, result.Amount);
            Assert.Equal(expected.Description, result.Description);
        }

        [Fact]
        public void ShouldParseMultiplesLines()
        {
            string[] csvList =
            {
                "30-01-2017,-50,Tesco",
                "01-02-2017,-40,Cinema",
                "05-02-2017,6000,Salary"
            };

            List<BankTransaction> bankTransactions = parser.ParseLinesFrom(csvList);

            Assert.Equal(3, bankTransactions.Count);
         }
    }
}