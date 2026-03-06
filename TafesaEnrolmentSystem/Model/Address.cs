using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem.Model
{
    public class Address
    {
        public const string DEFAULT_STREET_NUM = "No Number";
        public const string DEFAULT_STREET_NAME = "No Street";
        public const string DEFAULT_SUBURB = "No Suburb";
        public const string DEFAULT_POSTCODE = "No Postcode";
        public const string DEFAULT_STATE= "No State";
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb  { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }


        // no-arg constructor
        public Address() : this (DEFAULT_STREET_NUM, DEFAULT_STREET_NAME, DEFAULT_SUBURB, DEFAULT_POSTCODE, DEFAULT_STATE)
        {
           
        }

        // all-arg constructor
        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        // ToString
        public override string ToString()
        {
            return $"StreetNum: {StreetNum}, StreetName: {StreetName}, Suburb: {Suburb}, Postcode: {Postcode}, State: {State}";
        }


      

    }
}
