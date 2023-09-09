using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeDocumentos
{
    public class InvoiceImporter : Importer
    {
        private readonly string NAME_PREFIX = "Dear ";
        private readonly string AMOUNT_PREFIX = "Dear ";
        public Document ImporteFile(string path)
        {
            TextFile file = new TextFile(path);
            file.addLineSuffix(NAME_PREFIX, Attributes.PATIENT);
            file.addLineSuffix(AMOUNT_PREFIX, Attributes.PATIENT);

            Dictionary<string, string> attributes = file.GetAttributes();
            attributes[Attributes.TYPE] = "INVOICE";
            return new Document(attributes);
        }
    }
}
