﻿using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;


namespace User_Registration_Problem
{
    internal class User_Registration
    {
        bool pass = false;
        public void UserInputName()
        {
            if (pass == false)
            {
                Console.Write("Enter First Name : ");
                string firstName = Console.ReadLine();
                FirstNameAndLastName(firstName);
            }
            if (pass == true)
            {
                Console.Write("Enter Last Name : ");
                string LastName = Console.ReadLine();
                FirstNameAndLastName(LastName);
            }
        }
        public void FirstNameAndLastName(string Name)
        {
            Regex firstLastName = new Regex(@"^([A-z]{1}[a-z]{2,})$");
            bool matches = firstLastName.IsMatch(Name);
            if (matches == true)
            {
                pass= true;
                Console.WriteLine($"{Name} is Valid Name");
                return;
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Name {Name}");
                UserInputName();
            }
        }
        public void Email()
        {
            Console.Write("Enter Email ID : ");
            string email = Console.ReadLine();
            Regex emailID = new Regex(@"^(abc)[a-zA-Z0-9_\+\-\.]*[@](bl)*[.](co)*[.][a-z]{2}$");
            bool matches = emailID.IsMatch(email);
            if (matches == true)
            {
                Console.WriteLine($"{email} is Valid Email");
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Email {email}");
                Email();
            }
        }
        public void MobileNumber()
        {
            Console.Write("Enter Mobile Number with Country Code and Space between them : ");
            string mobileNumber = Console.ReadLine();
            Regex number = new Regex(@"^*[+][1-9]{1,3}\s[1-9]{1}[0-9]{9}$");
            bool matches = number.IsMatch(mobileNumber);
            if (matches == true)
            {
                Console.WriteLine($"{mobileNumber} is Valid Mobile Number");
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Mobile Number {mobileNumber}");
                MobileNumber();
            }
        }
        public void PassWord()
        {
            Console.WriteLine("Enter Password Contains 8 Characters : ");
            string password = Console.ReadLine();
            Regex pass = new Regex(@"^[a-zA-Z0-9]{8}$");
            bool matches = pass.IsMatch(password);
            if (matches == true)
            {
                Console.WriteLine($"{password} is Valid Password");
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Password {password}");
                PassWord();
            }
        }
    }
}
