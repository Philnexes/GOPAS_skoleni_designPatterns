using System.Collections.Generic;

namespace Calc.Models
{
    public class Logger : ILogger
    {
        public List<string> Items { get; private set; }
            = new List<string>();
        public void Write(string s) => Items.Add(s);
    }
}
