using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafesaEnrolmentSystem.Model
{
    public class Person
    {
        //constants:
        public const string DEFAULT_NAME = "No Name";
        public const string DEFAULT_EMAIL = "No Email";
        public const string DEFAULT_PHONE = "No Phone Number";
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Address Address { get; set; }


        // no-arg constructor
        public Person() : this (DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE, new Address() )
        {

        }

      
        // all-arg constructor
        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }


        // ToString
        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone Number: {PhoneNumber}, Address: {Address}";
        }

    }
}
