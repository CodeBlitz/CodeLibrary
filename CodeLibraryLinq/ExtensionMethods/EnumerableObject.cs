using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    // All extension method classes must be static!
    public static class EnumerableObject
    {
        // All extension methods must be static and start with "this" as the first input parameter.
        public static IEnumerable<T> FilterList<T>(this IEnumerable<T> items, Func<T, bool> testCondition)
        {
            // Since this is an extension method the object is expected to be an IEnumerable.
            foreach (var item in items)
            {
                // A Where method usually has a condition that must be met in order to return a value.
                if (testCondition(item) == true)
                {
                    // Yield helps mimic the IEnumerable functions for iteration.
                    yield return item;
                }
            }
        }
    }
}
