using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    struct ResponseOutput
    {
        public ResponseOutput(string a) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" ");
            Console.Write(new string('-', 20));
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(a);
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
