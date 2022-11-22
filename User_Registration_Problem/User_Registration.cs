using System;
using System.Text.RegularExpressions;


namespace User_Registration_Problem
{
    internal class User_Registration
    {
        public void FirstNameAndLastName(string Name)
        {
            Regex email = new Regex(@"^([A-z]{1}[a-z]{2,})$");
            bool matches = email.IsMatch(Name);

            if (matches == true)
            {
                Console.WriteLine($"{Name} is Valid Name");
            }
            else
            {
                Console.WriteLine($"Please Enter Valid Name {Name}");
            }
        }
    }
}
