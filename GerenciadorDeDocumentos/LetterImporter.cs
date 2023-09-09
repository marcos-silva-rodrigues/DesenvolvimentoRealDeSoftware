using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeDocumentos
{
    public class LetterImporter : Importer
    {
        private readonly string NAME_PREFIX = "Dear ";

        public Document ImporteFile(string path)
        {
            TextFile file = new TextFile(path);
            file.addLineSuffix(NAME_PREFIX, Attributes.PATIENT);

            int lineNumber = file.AddLines(2, value => String.IsNullOrEmpty(value), Attributes.ADDRESS);
            file.AddLines(lineNumber + 1, line => line.StartsWith("regards,"), Attributes.BODY);

            Dictionary<string, string> attributes = file.GetAttributes();
            attributes[Attributes.TYPE] = "LETTER";
            return new Document(attributes); 
        }
    }
}
