using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class StringReplacer
    {
        public string ReplaceOccurence(string destination, Dictionary<string,string> target)
        {
            if (destination == null)
            {
                throw new ArgumentNullException("The destination string cannot be empty");
            }

            return string.Empty;
        }
    }
}
