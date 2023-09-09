using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeDocumentos
{
    public interface Importer
    {

        Document ImporteFile(string path);
    }
}
