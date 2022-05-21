using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace TestRegex
{
    internal class Program
    {
        public static void Main()
        {
            Controller controller = new Controller();
            List<string> words = controller.read();
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
        }
    }
}
