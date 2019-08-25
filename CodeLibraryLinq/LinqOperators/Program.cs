using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;
using CodeLibrary;

namespace LinqOperators
{
    class Program
    {
        Data data = new Data();

        static void Main(string[] args)
        {
            Console.WriteLine("Program Linq Operators examples.");

            Program thisProgram = new Program();

            thisProgram.LinqFuncSelectFirst();

            // Boolean for any records.
            thisProgram.LinqFuncAny();

            // Take a number of records.
            thisProgram.LinqFuncTake(3);

            // List all states unique.
            thisProgram.ListStates();

            // List all people from a state code in contains list.
            thisProgram.SelectAllStateContains();

            thisProgram.AnyPeopleAvailable();

            Console.WriteLine("Program finished. Press any key to exit.");
            Console.ReadKey();
        }

        private void AnyPeopleAvailable()
        {
            Console.WriteLine("Determine if any people are available from the list.");

            bool any = data.people.Any(p => p.Available == true);
            Console.WriteLine(any);

            Console.WriteLine("Finished...");
        }


        private void SelectAllStateContains()
        {
            Console.WriteLine("List all people in state (LINQ keywords with Contains operator).");

            string[] states = { "CA", "NY", "FL" };

            var peopleList = data.people
                .Select(p => p)
                .Where(p => states.Contains(p.StateCode));

            peopleList.EnumToConsole<Person>();

            Console.WriteLine("Finished...");
        }

        private void ListStates()
        {
            Console.WriteLine("List all unique states from records.");

            var listStates = data.people
                .Select(person => person.StateCode)
                .Distinct()
                .OrderBy(stateCode => stateCode);

            listStates.EnumToConsole<string>();

            Console.WriteLine("Finished...");
        }

        private void LinqFuncSelectStateCodeCA()
        {
            Console.WriteLine("Seleting all records where statecode is CA in last name order.");

            var query1 = data.people.Where(p => p.StateCode == "CA").OrderBy(p => p.LastName);
            query1.EnumToConsole<Person>();

            Console.WriteLine("Finished...");
        }


        private void LinqFuncAny()
        {
            Console.WriteLine("Checking for any record with a transgender person in list.");

            var haveTransgender = data.people.Any(p => p.SexualIdentity == 'T');

            Console.WriteLine("Are any people transgender? {0}", haveTransgender);

            Console.WriteLine("Finished...");
        }

        private void LinqFuncSelectFirst()
        {
            Console.WriteLine("Seleting the first record.");

            // Pull just the first record.
            data.people.First<Person>().PrintToConsole();

            Console.WriteLine("Finished...");
        }

        private void LinqFuncTake(int numberOfRecordsToTake)
        {
            Console.WriteLine("Taking {0} records.", numberOfRecordsToTake);

            var takenPeople = data.people.Take(numberOfRecordsToTake);

            foreach (Person p in takenPeople)
            {
                p.PrintToConsole();
            }

            Console.WriteLine("Finished...");
        }
    }
}
