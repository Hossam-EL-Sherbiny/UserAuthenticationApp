// See https://aka.ms/new-console-template for more information

using UserAuthenticationApp;

UserAuthentication authentication = new();
Console.WriteLine("Welcome to the User Authentication System!");

while (true)
{
    Console.WriteLine("\nPlease select an option:");
    Console.WriteLine("1- Register");
    Console.WriteLine("2- Login");
    Console.WriteLine("3- Exist");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Enter Usernasme");
            string registerUsername = Console.ReadLine();

            Console.WriteLine("Enter Password");
            string registerPassword = Console.ReadLine();

            try
            {
                authentication.RegisterUser(registerUsername, registerPassword);
                Console.WriteLine("Registration successful!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

            case "2":
            Console.WriteLine("Enter Username: ");
            string loginUsername = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string loginPassword = Console.ReadLine();

            bool loggedIn = authentication.Login(loginUsername, loginPassword);

            if (loggedIn)
                Console.WriteLine("Login Successful!");
            else 
                Console.WriteLine("Invalid username or password.");
            break;

            case "3":
                Console.WriteLine("Exiting the program...");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Exiting the program...");
                break;
    }
}
