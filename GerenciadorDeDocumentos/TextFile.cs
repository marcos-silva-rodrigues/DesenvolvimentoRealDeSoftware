using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GerenciadorDeDocumentos
{
    public class TextFile
    {
        public Dictionary<string, string> Attributes  { get; private set; }
        private List<string> lines;

        public TextFile(string path)
        {
            Attributes = new Dictionary<string, string>
            {
                { "path", path }
            };
            lines = File.ReadLines(path).ToList();
        }

        public Dictionary<string, string> GetAttributes()
        {
            return Attributes;
        }

        public int AddLines(int start, Func<string, bool> isEnd, string attributeName)
        {
            var accumulator = new StringBuilder();
            int lineNumber;
            for (lineNumber = start; lineNumber < lines.Count; lineNumber++)
            {
                var line = lines[lineNumber];
                if (isEnd(line))
                {
                    break;
                }

                accumulator.Append(line);
                accumulator.Append("\n");
            }
            Attributes[attributeName] = accumulator.ToString().Trim();
            return lineNumber;
        }

        public void addLineSuffix(string prefix, string attributeName)
        {
            foreach (var line in lines)
            { 
                if (line.StartsWith(prefix))
                {
                    Attributes[attributeName] = line.Substring(prefix.Length);
                    break;
                }
            }
        }
    }
}
