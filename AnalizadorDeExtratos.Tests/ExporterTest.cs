using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos.Tests
{
    public class ExporterTest
    {

        [Fact]
        public void ShouldReturnHtmlWithStatistics()
        {
            var htmlExporter = new HtmlExporter();
            var statistics = new SummaryStatistics(12, 02, 21, 20);
            var isSum = "<li><strong>The sum is</strong>: 20";
            var isMax = "<li><strong>The max is</strong>: 12";
            var isMin = "<li><strong>The min is</strong>: 2";
            var isAverage = "<li><strong>The average is</strong>: 21";
            var result = htmlExporter.Export(statistics);

            Assert.Contains(isSum, result);
            Assert.Contains(isMax, result);
            Assert.Contains(isMin, result);
            Assert.Contains(isAverage, result);
        }

        [Fact]
        public void ShouldReturnConsoleTextWithStatistics()
        {
            var console = new ConsoleExporter();
            var statistics = new SummaryStatistics(12, 02, 21, 20);
            var isSum = "the sum is 20";
            var isMax = "the max is 12";
            var isMin = "the min is 2";
            var isAverage = "the average is 21";
            var result = console.Export(statistics);

            Assert.Contains(isSum, result);
            Assert.Contains(isMax, result);
            Assert.Contains(isMin, result);
            Assert.Contains(isAverage, result);
        }
    }
}
