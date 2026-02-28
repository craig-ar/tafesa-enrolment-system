using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem.Model
{
    public class Address
    {
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb  { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }


        // no-arg constructor
        public Address()
        {
            StreetNum = "No Number";
            StreetName = "No Street";
            Suburb = "No Suburb";
            Postcode = "No Postcode";
            State = "No State";
        }

        // ToString
        public override string ToString()
        {
            return $"StreetNum: {StreetNum}, StreetName: {StreetName}, Suburb: {Suburb}, Postcode: {Postcode}, State: {State}";
        }


        // all-arg constructor
        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State= state;
        }

    }
}
