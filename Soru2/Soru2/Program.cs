using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> snum = new List<string> { "15", "100", "125", "3500", "1" };
        
            var sortedNum= snum.OrderBy(x=>int.Parse(x)).ToList();
        
            Console.WriteLine("Ordered Numbers");

            foreach(var x in sortedNum) {  Console.WriteLine(x); }


        }
    }
}
