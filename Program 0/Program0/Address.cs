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
    class Address
    {
        private string _name; // Creates backing field for name
        private string _address1; // Creates backing field for address 1
        private string _address2; // Creates backing field for address 2
        private string _city; // Creates backing field for city
        private string _state; // Creates backing field for state
        private int _zip; // Creates backing field for zip code

        public Address(string name, string a1, string a2, string city, string state, int zip) // Creates 6 parameter constructor named Address
        {
            Name = name; // Sets property Name = n
            Address1 = a1; // Sets property Address1 = a1
            Address2 = a2; // Sets property Address2 = a2
            City = city; // Sets property City = c
            State = state; // Sets property State = s
            Zip = zip; // Sets property Zip = z
        }


        public Address(string n, string a1, string c, string s, int z)
        {
            Name = n; // Sets property Name = n
            Address1 = a1; // Sets property Address1 = a1
            City = c; // Sets property City = c
            State = s; // Sets property State = s
            Zip = z; // Sets property Zip = z
        }

        public string Name // Creates Name property
        {
            // Precondition:  None
            // Postcondition: The name has been returned
            get
            {
                return _name; // Return backing field 
            }

            // Precondition:  None
            // Postcondition: The name has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Input a name"); // If the string is left blank or is just white space shut down the program
                }
                else
                {
                    _name = value; // Sets name backing field equal to value
                }

            }
        }

        public string Address1 // Creates Address1 property
        {
            // Precondition:  None
            // Postcondition: The Address1 has been returned
            get
            {
                return _address1; // Return backing field 
            }

            // Precondition:  None
            // Postcondition: The address1 has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Input an address 1"); // If the string is left blank or is just white space shut down the program
                }
                else
                {
                    _address1 = value; // Sets address1 backing field equal to value
                }
            }
        }

        public string Address2 // Creates Address2 property
        {
            // Precondition:  None
            // Postcondition: The Address2 has been returned
            get
            {
                return _address2; // Return backing field 
            }

            // Precondition:  None
            // Postcondition: The address2 has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Input an address 2"); // If the string is left blank or is just white space shut down the program
                }
                else
                {
                    _address2 = value; // Sets address 2 backing field equal to value
                }
            }
        }

        public string City // Creates City property
        {
            // Precondition:  None
            // Postcondition: The city has been returned
            get
            {
                return _city; // Return backing field 
            }

            // Precondition:  None
            // Postcondition: The city has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Input a city"); // If the string is left blank or is just white space shut down the program
                }
                else
                {
                    _city = value; // Sets city backing field equal to value
                }
            }
        }

        public string State // Creates State property
        {
            // Precondition:  None
            // Postcondition: The state has been returned
            get
            {
                return _state; // Return backing field 
            }

            // Precondition:  None
            // Postcondition: The state has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Input a state"); //If the string is left blank or is just white space shut down the program
                }
                else
                {
                    _state = value; // Sets state backing field equal to value
                }
            }
        }

        public int Zip // Creates Zip property
        {
            // Precondition:  None
            // Postcondition: The zip has been returned
            get
            {
                return _zip; // Return backing field 
            }

            // Precondition:  value >= 0 and value <= 99999
            // Postcondition: The Zip has been set to the specified value
            set
            {
                if (value >= 0 && value <= 99999)
                    _zip = value; // If input follows requirements, set the backing field equal to the value
                else
                    throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(Zip)} must be 0-99999"); // When invalid, give error message instead
            }
        }

        public override string ToString() =>
      $"{Name}\n{Address1}\n{Address2}\n{City}, {State} {Zip:D5}"; // Creates ToString that will format how the output of the class will look

        public static implicit operator Address(string v)
        {
            throw new NotImplementedException(); // 
        }
    }
}
