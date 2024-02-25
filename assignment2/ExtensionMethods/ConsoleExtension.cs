using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment2.ExtensionMethods
{
    public static class ConsoleExtensions
    {
        public static void Log(this string message)
        {
            Console.WriteLine(message);
        }

        public static void Log<T>(this IEnumerable<T> items, string header = "")
        {
            if (!string.IsNullOrEmpty(header))
            {
                Console.WriteLine(header);
            }

            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}