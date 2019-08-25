using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using CodeLibrary;

namespace LinqQuerySyntax
{
    public class Program
    {
        Data data = new Data();

        static void Main(string[] args)
        {
            Console.WriteLine("Program Linq Query Syntax examples.");
            Program thisProgram = new Program();

            // Create data objects used by linq expressions.
            //thisProgram.InitializePrivates();

            // Pull just the first record.
            thisProgram.LinqQuerySelectFirst();
            
            // Calling a query with a where condition.
            thisProgram.LinqQueryStateCA();

            // Get all unique state codes.
            thisProgram.ListStates();

            // Get all people with state from contains list.
            thisProgram.SelectAllStateContains();

            Console.WriteLine("Program finished. Press any key to exit.");
            Console.ReadKey();
        }

        private void ListStates()
        {
            Console.WriteLine("List all unique state codes.");

            var stateList = (from p in data.people
                             orderby p.StateCode
                             select p.StateCode).Distinct();

            stateList.EnumToConsole<string>();

            Console.WriteLine("Finished...");
        }

        private void SelectAllStateContains()
        {
            Console.WriteLine("List all people in state (LINQ keywords with Contains operator).");

            string[] states = { "CA", "NY", "FL" };

            var peopleList = from p in data.people
                            where states.Contains(p.StateCode)                             
                            select p;

            peopleList.EnumToConsole<Person>();

            Console.WriteLine("Finished...");
        }


        private void LinqQueryStateCA()
        {
            Console.WriteLine("Seleting all records where statecode is CA in last name order.");

            var people = from p in data.people
                         where p.StateCode == "CA"
                         orderby p.LastName
                         select p;

            people.EnumToConsole<Person>();

            Console.WriteLine("Finished...");
        }


        private void LinqQuerySelectFirst()
        {
            Console.WriteLine("Seleting the first record.");

            // Pull just the first record.
            var person = (from p in data.people
                          select p).First();
            person.PrintToConsole();

            Console.WriteLine("Finished...");
        }   
    }
}
