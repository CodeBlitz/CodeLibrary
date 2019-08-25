using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ConsoleUtilities
    {        
        public static void PrintToConsole<T>(this T value)
        {            
            // Cast the object to type T.
            Console.WriteLine(value.ToString());
        }

        public static void EnumToConsole<T>(this IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ConsoleWriteLine(this object value)
        {
            Console.WriteLine();
        }

        public static void ConsoleKeyWait(this object value)
        {
            Console.ReadKey();
        }
    }
}
