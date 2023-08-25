using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> mixList = new List<object> {40, 16, "Hi", 10, "C#", 100, ".NET" };

            var onlyString=mixList.OfType<string>().ToList();

            Console.WriteLine("Strings = ");
            foreach(var str in onlyString)
            {
                Console.WriteLine(str);
            }

        }
    }
}
