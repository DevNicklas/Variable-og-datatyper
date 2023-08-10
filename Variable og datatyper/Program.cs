using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_og_datatyper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 16;
            double width = 5.1;

            // Opgave b
            // Vil ikke virke, da jeg prøver at putte et kommatal i et heltal altså double i integer
            int area = width * length;

            // Opgave c
            // Virker da det ikke er et problem at putte heltal i kommatal, altså integer i double
            double d = width * length;

            Console.WriteLine(length*width);
            Console.WriteLine(area);
            Console.WriteLine(d);
        }
    }
}
