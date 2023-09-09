using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeDocumentos
{
    public class DocumentManagementSystem
    {
        private List<Document> Documents = new List<Document>();
        private Dictionary<string, Importer> extensionToImporter = new Dictionary<string, Importer>();

        public DocumentManagementSystem()
        {
            this.extensionToImporter.Add("letter", new LetterImporter());
            this.extensionToImporter.Add("invoice", new InvoiceImporter());
            this.extensionToImporter.Add("jpg", new ImageImporter());
        }

        public void importFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(filePath);
            }

            int separatorIndex = filePath.LastIndexOf(".");
            if (separatorIndex == -1)
            {
                if (separatorIndex == filePath.Length)
                {
                    throw new FileLoadException("No extension found For file: " + filePath);
                }
                string extension = filePath.Substring(separatorIndex + 1);
                var importFile = extensionToImporter[extension];
                if (importFile == null)
                {
                    throw new FileLoadException("For file: " + filePath);
                }

                var document = importFile.ImporteFile(filePath);
                Documents.Add(document);
            }
            else
            {
                throw new FileLoadException("No extension found For file: " + filePath);
            }
        }

        public List<Document> Contents()
        {
            return Documents;
        }
    }
}
