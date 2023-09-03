using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AnalizadorDeExtratos.Tests
{
    public class BankStatementProcessorTest
    {
        private BankStatementProcessor processor;
        public BankStatementProcessorTest()
        {
            List<BankTransaction> bankTransactions = new List<BankTransaction>()
            {
                new BankTransaction(Convert.ToDateTime("30-01-2023"), -200, "Study"),
                new BankTransaction(Convert.ToDateTime("01-02-2023"), -160, "Delivery"),
                new BankTransaction(Convert.ToDateTime("02-02-2023"), -30, "Transport"),
                 new BankTransaction(Convert.ToDateTime("05-02-2023"), 6000, "Salary"),
                 new BankTransaction(Convert.ToDateTime("07-02-2023"), -60, "Delivery"),
                 new BankTransaction(Convert.ToDateTime("12-02-2023"), 2000, "Salary"),
            };

            processor = new BankStatementProcessor(bankTransactions);
        }

        [Fact]
        public void ShouldReturnMinAmount()
        {
            Assert.Equal(-200, processor.CalculateMinAmount());
        }

        [Fact]
        public void ShouldReturnMinAmountInDeterminadeDates()
        {
            var period = new Period(Convert.ToDateTime("01-02-2023"), Convert.ToDateTime("10-02-2023"));
            Assert.Equal(-160, processor.CalculateMinAmount(period));
        }

        [Fact]
        public void ShouldReturnMaxAmount()
        {
            Assert.Equal(6000, processor.CalculateMaxAmount());
        }

        [Fact]
        public void ShouldReturnMaxAmountInDeterminadeDates()
        {
            var period = new Period(Convert.ToDateTime("06-02-2023"), Convert.ToDateTime("12-02-2023"));
            Assert.Equal(2000, processor.CalculateMaxAmount(period));
        }


    }
}
