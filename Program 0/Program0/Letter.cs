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
    class Letter : Parcel
    {
        public decimal FixedCost;

        public Letter(string originAddress, string destinationAddress, decimal fixedCost)
            : base(originAddress, destinationAddress) // Creates 3 parameter constructor for Letter, and addresses base class Parcel
        {
            OriginAddress = originAddress; // Sets OriginAddress = originAddress in Parameter
            DestinationAddress = destinationAddress; // Sets DestinationAddress = destinationaddress in Parameter
            FixedCost = fixedCost; // Sets FixedCost = fixedCost in Parameter

        }

        public override decimal CalcCost()
        {
            return FixedCost; // Has CalcCost method overriden to return FixedCost that gains a value from the Parameter
        }

        public override string ToString() =>
      $"{OriginAddress}\n{DestinationAddress}\n{FixedCost:C}"; // Creates ToString that formats the utput of the class
    }
}
