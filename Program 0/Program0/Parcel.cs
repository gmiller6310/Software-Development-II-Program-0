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
    abstract class Parcel
    {
        public Parcel(Address originAddress, Address destinationAddress) // Creates constructor for Parcel with 2 parameters that are run through the Address class
        {
            OriginAddress = originAddress; // Sets OriginAddress equal to parameter originAddress
            DestinationAddress = destinationAddress; // Sets DestinationAddress equal to parameter destinationAddress
        }

        // Get Precondition: None
        // Get Postcondition: None

        // Set Precondition: None
        // Set Precondition: None
        public Address OriginAddress { get; set; } // creates get and set accessors for OriginAddress

        // Get Precondition: None
        // Get Postcondition: None

        // Set Precondition: None
        // Set Precondition: None
        public Address DestinationAddress { get; set; } // creates get and set accessors for Destination Address

        abstract public decimal CalcCost(); // Creates abstract method names CalcCost that can be used by sub-classes

        public override string ToString() =>
      $"{OriginAddress}\n{DestinationAddress}"; // Creates ToString method for formatting Origin Address and Destination Address
    }
}
