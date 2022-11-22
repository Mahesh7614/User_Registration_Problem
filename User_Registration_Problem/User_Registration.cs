using System;
using System.Text.RegularExpressions;


namespace User_Registration_Problem
{
    internal class User_Registration
    {
        public static void SampleEmail(string pattern)
        {
            Regex email = new Regex(@"^(abc)([_\+\-\.]{0,1}[a-zA-Z0-9])*[@][a-z0-9]{1,} *[.][a-z]{2,}[\.\,]{0,}[a-z]{0,}$");
            bool matches = email.IsMatch(pattern);

            if (matches == true)
            {
                Console.WriteLine("Email ID is Valid");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Email ID");
            }
        }
    }
}
