using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GerenciadorDeDocumentos
{
    public class ImageImporter : Importer
    {
        public Document ImporteFile(string path)
        {
            var map = new Dictionary<string, string>();
            map.Add("path", path);

            var newImage = Image.FromFile(path);
            map.Add("width", newImage.Width.ToString());
            map.Add("height", newImage.Height.ToString());
            map.Add("type", newImage.GetType().ToString());

            return new Document(map);
        }
    }
}
