using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Models
{
    public class Logger : ILogger
    {
        public List<string> Items { get; private set; }
            = new List<string>();
        public void Write(string s) => Items.Add(s);
    }
}
