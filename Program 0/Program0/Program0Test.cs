//Grading ID: C6485
// Program #: 0
// Due Date: September 11, 2017 11:59 P.M.
// Course Number: CIS200-01
// Brief Decsription: Creates a system of classes that deals with shipping and receiving of packages from a company such as UPS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Program0Test
    {
        static void Main(string[] args)
        {}
            private Address home = new Address("John Smith", "414 Fairview Street", "Benton", "Kentucky", 42025); // Creates an Address Object

        private Address vacation = new Address("Jane Doe", "709 Rockery Way", "Apartment 104", "Louisville", "Kentucky", 40208); // Creates an Address Object

        private Address condo = new Address("James Jones", "4626 South 3rd Street", "Louisville", "Kentucky", 40214); // Creates an Address Object

        private Address family = new Address("Everett Sutherland", "249 Castleberry Lane", "Benton", "Kentucky", 42025); // Creates an Address Object



        private Letter mother = new Letter("414 Fairview Street", "4626 South 3rd Street", 3); // Creates a Letter Object

        private Letter father = new Letter("709 Rockery Way Apartment 104", "249 Castleberry Lane", 5); // Creates a Letter Object

        private Letter brother = new Letter("414 Fairview Street", "709 Rockery Way Apartment 104", 3); // Creates a Letter Object

        List<Parcel> parcelList = new List<Parcel>(); // Creates a list to contain Letter objects
        

    }
}
