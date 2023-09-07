using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos
{
    public class FileImporter : Importer
    {

        private static readonly string RESOURCES = "../";
        private readonly string _filePath;

        public FileImporter(string filePath)
        {
            _filePath = filePath;
        }

        public string[] importer()
        {
            string[] readText = File.ReadAllLines(RESOURCES + _filePath);
            return readText;
        }
    }
}
