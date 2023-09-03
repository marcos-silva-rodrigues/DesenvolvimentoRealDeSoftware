using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos
{
    public class BankStatementCSVParser: BankStatementParser
    {
       
        public BankTransaction ParseFrom(string line)
        {
            string[] columns = line.Split(',');
            DateTime date = Convert.ToDateTime(columns[0]);
            double amount = Convert.ToDouble(columns[1]);
            string description = columns[2];

            return new BankTransaction(date, amount, description);
        }

        public List<BankTransaction> ParseLinesFrom(string[] lines)
        {
            List<BankTransaction> list = new List<BankTransaction>();
            foreach (string line in lines)
            {
                list.Add(ParseFrom(line));
            }

            return list;
        }
    }
}
