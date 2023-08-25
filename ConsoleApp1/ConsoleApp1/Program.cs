using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringNumbers = new List<string>
        {
            "42",
            "7",
            "16",
            "10",
            "99"
        };

            var sortedNumbers = stringNumbers.OrderBy(num => int.Parse(num)).ToList();

            Console.WriteLine("Sorted Numbers:");
            foreach (var num in sortedNumbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
