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
            // Kompileren har problemer da det er 2 forskellige datatyper
            // Den konventere ikke automatisk selv og derfor giver den fejl.
            // Siden variablen area er en int, og derfor kan man ikke bruge datatypen double
            int area = width * length;

            // Opgave c
            // Nu passer datatypen til double til vores variabel width, er den forstår nu at kompilere koden.
            double d = width * length;

            Console.WriteLine(length*width);
            Console.WriteLine(area);
            Console.WriteLine(d);
        }
    }
}
