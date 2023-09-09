using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeDocumentos
{
    public class Document
    {

        private Dictionary<string, string> Attributes {  get; set; }

        public Document(Dictionary<string, string> attributes)
        {
            Attributes = attributes;
        }

        public string GetAttribute(string name)
        {
            return Attributes[name];
        }
    }
}
