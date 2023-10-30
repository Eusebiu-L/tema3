namespace AutentificareTema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new (string username, string password)[]
           {
                ("user1", "pass1"),
                ("user2", "pass2"),
                ("user3", "pass3"),
                ("Eusebiu", "UEO")
           };
            bool Logged = false;

            do
            {
                Console.WriteLine("Enter user: ");
                string inputUsername = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string inputPassword = Console.ReadLine();

                foreach (var user in users)
                {
                    if (inputUsername == user.username && inputPassword == user.password)
                    {
                        Logged = true;
                        Console.WriteLine($"Welcome, {inputUsername}!");
                        break;
                    }
                }

                if (!Logged)
                {
                    Console.WriteLine("Invalid password or username, please try again");
                }
            } while (!Logged);
        }
    }
}