using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLibrary;
using ExtensionMethods;

namespace Delegates
{
    // Define a delegate that accepts two integers and returns an integer.
    // A delegate does not allow for summary comments and does not show the pointers summary comments.
    public delegate int TwoIntegerDelegate(int firstInteger, int secondInteger);

    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Program delegate assignment examples.");

            int result;

            // FIRST and best method.
            // Here we can just assign the delegate by pointing it to the method.
            TwoIntegerDelegate twoIntAdd = AddTwoIntegers;

            // We can call the delegate like a method, but I think this can confuse things a bit.
            // Intellisencse shows the following "int twoIntAdd(int firstInteger, int secondInteger)" which is nice and readable.
            // However, this does not speak to the specific method that is being called.
            result = twoIntAdd(5, 7);
            result.PrintToConsole();

            // SECOND and least favorite.
            // Initialize the delegate by newing up an instance and including the method as a pointer in the constructor.            
            // I DO NOT like this since the new keyword is misleading by suggesting a delegate is like a class.
            TwoIntegerDelegate twoIntMultiply = new TwoIntegerDelegate(MultiplyTwoIntegers);

            // We can call Invoke on this delegate. I like this since it is clear that it is a delegate.
            result = twoIntMultiply.Invoke(3, 11);
            result.PrintToConsole();


            // Here we can call a different method that takes the delegate.
            bool flag = HandleNumbers(twoIntMultiply, 9, 33);
            flag.PrintToConsole();

            Console.WriteLine("Program finished. Press any key to exit.");
            Console.ReadKey();
        }


        static bool HandleNumbers(TwoIntegerDelegate inputDelegate, int a, int b)
        {
            int result;

            result = inputDelegate(a, b);

            if (result > 5)
                return true;
            return false;
        }


        /// <summary>
        /// Add two integers
        /// </summary>
        /// <param name="firstInteger">First Integer to add</param>
        /// <param name="secondInteger">Second Integer to add</param>
        /// <returns>The sum of both integers</returns>
        static int AddTwoIntegers(int a, int b)
        {
            // This method signature matches the TwoIntegerDelegate definition.
            return a + b;
        }


        /// <summary>
        /// Multiple two integers
        /// </summary>
        /// <param name="firstInteger">First Integer to multiply</param>
        /// <param name="secondInteger">Second Integer to multiply</param>
        /// <returns>The product of both integers</returns>
        static int MultiplyTwoIntegers(int x, int y)
        {
            // This also matches the TwoIntegerDelegate definition.
            return x * y;
        }
    }
}
