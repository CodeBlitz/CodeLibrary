using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using CodeLibrary;

namespace LooseCoupling
{    
    class Program
    {
        // Private delegates need to be declared inside a class.

        /// <summary>
        /// Test the string for a condition.
        /// </summary>
        /// <param name="s">String value to be tested</param>
        /// <returns>True if condition is met.</returns>
        private delegate bool TestDel(string s);

        static void Main(string[] args)
        {
            Console.WriteLine("Program Loose Coupling with delegate examples.");

            Data data = new Data();

            string[] result;

            Console.WriteLine("Total records is {0}", data.people.Count().ToString());

            // Get the data we need for this example. Pull first name only as string array.
            string[] items = data.people.Select(p => p.FirstName).Distinct().ToArray();

            // We will pass the name of the static method that matches the delegate signature.            
            result = WhereDelegated(items, TestForLength);

            // Here we can declare the delegate at the moment we are calling the Where method.
            result = WhereDelegated(items, new TestDel(TestForLength));

            // Or we can just define an genereic Func delegate.
            int maxLength = 3;
            Func<string, bool> testFunc = delegate(string s)
            {
                return s.Length > maxLength;
            };

            // ERROR: This does not work because the method calls for a specific delegate.
            //result = Where(items, testFunc);

            // We can call the function using the Func delegate variable.
            result = WhereFuncd(items, testFunc);

            // The delegate can also be enbedded in the call directly. Cluttered!
            result = WhereDelegated(items, delegate(string s)
            {
                return s.Length > maxLength;
            });

            // Even better we can use a LAMBDA expression which is short hand for an anomyous delegate.
            // This works for both a defined delegate or a Func delegate.
            result = WhereDelegated(items, (s => s.Length > maxLength));
            result = WhereFuncd(items, (s => s.Length > maxLength));

            foreach (var s in result)
            {
                s.PrintToConsole();
            }

            Console.WriteLine("Program finished. Press any key to exit.");
            Console.ReadKey();
        }


        static bool TestForLength(string s)
        {
            return s.Length > 3;
        }


        // This method call requires a delegate that matches the defined TestDel.
        static string[] WhereDelegated(string[] items, TestDel test)
        {
            var result = new List<string>();
            foreach (var item in items)
            {
                if (test(item))
                    result.Add(item);
            }

            return result.ToArray();
        }


        static string[] WhereFuncd(string[] items, Func<string, bool> test)
        {
            var result = new List<string>();
            foreach (var item in items)
            {
                if (test(item))
                    result.Add(item);
            }

            return result.ToArray();
        }
    }
}
