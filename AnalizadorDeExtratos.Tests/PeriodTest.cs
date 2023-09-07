using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos.Tests
{
    public class PeriodTest
    {

        [Fact]
        public void ShouldReturnTrueInRangeDates()
        {
            var startDate = new DateTime(2023, 09, 07);
            var endDate = new DateTime(2023, 09, 30);

            var period = new Period(startDate, endDate);
            Assert.True(period.Range(new DateTime(2023, 09, 12)));
        }

        [Fact]
        public void ShouldReturnFalseInDateOutOfRange()
        {
            var startDate = new DateTime(2023, 09, 07);
            var endDate = new DateTime(2023, 09, 30);

            var period = new Period(startDate, endDate);
            Assert.False(period.Range(new DateTime(2023, 07, 05)));
            Assert.False(period.Range(new DateTime(2023, 10, 01)));
        }

        [Fact]
        public void ShouldReturnTrueInLimitDate()
        {
            var startDate = new DateTime(2023, 09, 07);
            var endDate = new DateTime(2023, 09, 30);

            var period = new Period(startDate, endDate);
            Assert.True(period.Range(new DateTime(2023, 09, 30)));
            Assert.True(period.Range(new DateTime(2023, 09, 07)));
        }
    }
}
