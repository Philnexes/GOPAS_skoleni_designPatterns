using System.Collections.Generic;

namespace Calc.Models
{
    public interface ILogger
    {
        List<string> Items { get; }

        void Write(string s);
    }
}