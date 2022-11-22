namespace User_Registration_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************** User Registration Form **************************");
            User_Registration user = new User_Registration();
            user.UserInputName();
            user.Email();
            user.MobileNumber();
            user.PassWord();
        }
    }
}