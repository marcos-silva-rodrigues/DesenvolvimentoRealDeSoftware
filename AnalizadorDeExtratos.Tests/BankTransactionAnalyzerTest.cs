using AnalizadorDeExtratos.Tests.Mocks;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos.Tests
{
    public class BankTransactionAnalyzerTest
    {

        [Fact]
        public void ShouldCallDependenciesInAnalyze()
        {
            var importMock = new MockImporter();
            var parserMock = new MockParser();

            var exportMock = new Mock<Exporter>();
            exportMock.Setup(exportMock => exportMock.Export(It.IsAny<SummaryStatistics>())).Returns("");

            var analize = new BankTransactionAnalyzer();
            analize.Analyze(importMock, parserMock, exportMock.Object);

            exportMock.Verify();
        }
    }
}
