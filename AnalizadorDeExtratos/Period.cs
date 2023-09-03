using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeExtratos
{
    public class Period
    {

        private DateTime _start;
        private DateTime _end;
        public Period(DateTime start, DateTime end)
        {
            _start = start;
            _end = end;
        }

        public bool Range(DateTime date)
        {
           return date >= _start &&  date <= _end;
        }
    }
}
