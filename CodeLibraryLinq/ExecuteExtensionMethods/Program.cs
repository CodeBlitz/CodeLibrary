using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using CodeLibrary;

namespace ExecuteExtensionMethods
{
    public class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Program extension method examples.");

            Data data = new Data();

            IEnumerable<int> evens;

            // Get a list of even number from existing data list of randome ints.
            // We can call an extension method directly by just calling it as normal.
            //  In that case we need to provide the THIS object as the first parameter.
            evens = EnumerableObject.FilterList(data.numberList, (intNumber) => { return (intNumber % 2 == 0); });

            // We can als call the extension method directly on the collection IEnumerable.
            evens = data.numberList.FilterList((intNumber) => { return (intNumber % 2 == 0); }); 
            evens = data.numberList.FilterList((i => i % 2 == 0));

            // This requires an IEnuerable<string> implementation of the ext method.
            evens.EnumToConsole();

            Console.WriteLine("Program finished. Press any key to exit.");
            Console.ReadKey();
        }

        private static int ComprareTwoInts(int a, int b)
        {
            return 0;
        }
    }
}
