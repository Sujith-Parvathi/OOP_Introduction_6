﻿using System;

namespace OOP_Introduction
{
    class Person
    {
        public string firstName;
        public string lastName;
        public DateTime dateofbirth;

        // class variables as properties
        //public string firstName { get; set; }

        // static variables
        public static string salutationMr = "Mr";

        /// <summary>
        /// Method to return the person's name
        ///   in a printable version
        /// </summary>
        /// <returns>Person's full name</returns>
        public string getName()
        {
            return firstName + " " + lastName;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Person()
        {
            ///firstName = "John";
            ///lastName = "Doe";
        }

        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="lname">last name of the person</param>
        public Person(string firstName , string lastName)
        {
           this.firstName = firstName;
           this.lastName = lastName;
        }
        
    }
}