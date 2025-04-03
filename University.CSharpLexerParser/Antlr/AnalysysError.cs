using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antlr4VS.Antlr
{
    public class AnalysysError
    {
        public int Line { get; set; }
        public int CharPositionInLine { get; set; }
        public string Message { get; set; }
    }
}
