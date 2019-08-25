using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLibrary
{
    public class Data
    {
        public List<int> numberList;
        public List<Person> people;

        public Data()
        {
            // A random number list for sorting and other analysis.
            numberList = new List<int>() { 0, 8, 1, 3, 17, 99999, 432, 5, 15, 3, -4, 88, 11, 22, -1, 321, -7, 65 };

            // A list of people
            this.people = new List<Person>()
            {
                new Person() { PersonID=1, FirstName="Mike", LastName="Smith", Age=33, HourlyRate=14.24m, Available=true, SexualIdentity='M', StateCode="CA"},
                new Person() { PersonID=1, FirstName="Sue", LastName="Brook", Age=19, HourlyRate=11.71m, Available=true, SexualIdentity='F', StateCode="MA"},
                new Person() { PersonID=1, FirstName="Jim", LastName="Smith", Age=25, HourlyRate=25.10m, Available=true, SexualIdentity='M', StateCode="NM"},
                new Person() { PersonID=1, FirstName="Mike", LastName="Jones", Age=45, HourlyRate=33.33m, Available=false, SexualIdentity='M', StateCode="NY"},
                new Person() { PersonID=1, FirstName="Tracey", LastName="Shoemaker", Age=62, HourlyRate=12.41m, Available=true, SexualIdentity='T', StateCode="NY"},
                new Person() { PersonID=1, FirstName="Janet", LastName="Smith", Age=22, HourlyRate=24.99m, Available=true, SexualIdentity='F', StateCode="CA"},
                new Person() { PersonID=1, FirstName="April", LastName="Banker", Age=37, HourlyRate=14.24m, Available=true, SexualIdentity='M', StateCode="CA"},
                new Person() { PersonID=1, FirstName="Kelley", LastName="Mathews", Age=19, HourlyRate=11.71m, Available=true, SexualIdentity='F', StateCode="MA"},
                new Person() { PersonID=1, FirstName="Jill", LastName="Jones", Age=25, HourlyRate=25.10m, Available=false, SexualIdentity='M', StateCode="NM"},
                new Person() { PersonID=1, FirstName="Lee", LastName="Kim", Age=64, HourlyRate=33.33m, Available=false, SexualIdentity='M', StateCode="NY"},
                new Person() { PersonID=1, FirstName="Kim", LastName="Park", Age=41, HourlyRate=12.41m, Available=true, SexualIdentity='T', StateCode="NY"},
                new Person() { PersonID=1, FirstName="Donna", LastName="Thomas", Age=19, HourlyRate=24.99m, Available=true, SexualIdentity='F', StateCode="FL"}
            };
        }
    }

    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal HourlyRate { get; set; }
        public bool Available { get; set; }
        public char SexualIdentity { get; set; }
        public string StateCode { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} age {2} sex {3} from {4} is available {5}.", FirstName, LastName, Age.ToString(), SexualIdentity, StateCode, Available.ToString());
        }
    }
}
