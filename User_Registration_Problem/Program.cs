namespace User_Registration_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Email Id Given in Chart : ");
            string email = Console.ReadLine();
            User_Registration.Pattern(email);
        }
    }
}