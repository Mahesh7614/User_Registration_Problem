﻿namespace User_Registration_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User_Registration user = new User_Registration();
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();
            user.FirstNameAndLastName(firstName);
        }
    }
}