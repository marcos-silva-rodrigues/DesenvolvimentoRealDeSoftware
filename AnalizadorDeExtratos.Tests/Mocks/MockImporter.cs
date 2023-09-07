using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos.Tests.Mocks
{
    public class MockImporter : Importer
    {
        public string[] importer()
        {
            string[] line = { "05-02-2017,6000,Salary" };
            return line;
        }
    }
}
