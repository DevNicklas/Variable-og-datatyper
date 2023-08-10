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
            // Wouldn't work when you try to put an decimal number in a integer, also called double
            // and integer when we talk about datatypes.
            int area = width * length;

            // Opgave c
            // Works since you can put a integer in a decimal number, but not the other way around.
            double d = width * length;

            Console.WriteLine(length*width);
            Console.WriteLine(area);
            Console.WriteLine(d);
        }
    }
}
