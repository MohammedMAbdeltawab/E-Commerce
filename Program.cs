using E_Commerce;
using System.Collections.Concurrent;

Console.WriteLine("Hello, World!");

AuthenticationManager authenticationManager = new AuthenticationManager();

int currentAttempt = 0, maxAttempt = 3;
bool isSuccess = false;

Console.WriteLine($"===> Login Page <===");

while (currentAttempt < maxAttempt)
{

    Console.Write($"Email: ");
    string email = Console.ReadLine();

    Console.Write($"Password: ");
    string password = Console.ReadLine();

    User loggedInUser = authenticationManager.Login(email, password);
    if (loggedInUser is not null)
    {
        isSuccess = true;

        if (loggedInUser.Role.Name == "Admin")
        {
            Console.WriteLine($"\n Hello {loggedInUser.Role.Name}: {loggedInUser.Name}");
        }
        else
        {
            Console.WriteLine($"\n Hello {loggedInUser.Name}");
        }
        break;
    }
    else
    {
        currentAttempt++;
        Console.WriteLine($"InCorrect Email Or Password remaining Attemptes:{maxAttempt - currentAttempt}");
    }
}

if (!isSuccess)
{
    Console.WriteLine("Maximum login attempts reached. Session closed.");
}




