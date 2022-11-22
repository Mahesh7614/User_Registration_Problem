using System;
using System.Text.RegularExpressions;


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
    }
}
