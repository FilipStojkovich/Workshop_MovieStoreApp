using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Helpers.cs.Models;

Console.WriteLine("Welcome to the Movie Store app!\n1.Press 1 if you are an Employee\n2.Press 2 if you are a User");
int userInputEmployeeOrUser = int.Parse(Console.ReadLine());

if(userInputEmployeeOrUser == 1)
{
    Services.cs.Services.ValidateLogInEmployee(DataBase.Employees);

    Console.WriteLine("a. See all registered members in the movie store.\n" +
                                     "b. See all movies available for renting.\n" +
                                     "c. Add new members.\n" +
                                     "d. Delete existing members.");
    string employeeInputAction = Console.ReadLine();

    if(employeeInputAction.ToLower() == "a")
    {
        Helpers.cs.Helpers.SeeAllRegisteredMembers(DataBase.Users);
    }
    else if(employeeInputAction.ToLower() == "b")
    {
        Helpers.cs.Helpers.SeeAllMoviesAvailable(DataBase.Movies);
    }
    else if(employeeInputAction.ToLower() == "c")
    {
        Services.cs.Services.RegisterNewMember(DataBase.Users);
    }
    else if(employeeInputAction.ToLower() == "d")
    {
        Console.WriteLine("Which User do you want to delete?(1/2/3/4/5)");

        for (int i = 0; i < DataBase.Users.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {DataBase.Users[i].FirstName} {DataBase.Users[i].LastName}");
        }

        int userInputNumber = int.Parse(Console.ReadLine());

        Services.cs.Services.DeleteMembers(DataBase.Users, userInputNumber);
    }
    else
    {
        Console.WriteLine("You did not enter a valid option!");
    }
}
else if(userInputEmployeeOrUser == 2)
{
    Console.WriteLine("Do you have an account?\n1. Press 1 if you have an account\n2. Press 2 if you don't have an account");
    int userHasAccountOrNot = int.Parse(Console.ReadLine());

    if(userHasAccountOrNot == 1)
    {
        var user = Services.cs.Services.LogInUser(DataBase.Users);

        Console.WriteLine("1. See your Info.\n2. Select a movie from the list\n3. See all rented movies");
        int logInUserAction = int.Parse(Console.ReadLine());

        if (logInUserAction == 1)
        {
            Helpers.cs.Models.Members.DisplayInfoForUser(DataBase.Users, user.Username);
        }
        else if (logInUserAction == 2)
        {            
            Helpers.cs.Helpers.SelectMovieFromList(DataBase.Movies);

            Console.WriteLine("Which one would you like to rent?");
            int userInputRentMovieNumber = int.Parse(Console.ReadLine());

            Helpers.cs.Helpers.RentMovieFromList(DataBase.Movies, userInputRentMovieNumber);
        }
        else if(logInUserAction == 3)
        {
            Helpers.cs.Helpers.SeeAllRentedMovies(DataBase.Movies);
        }
        else
        {
            Console.WriteLine("Please enter a valid number!");
        }
    }
    else if(userHasAccountOrNot == 2)
    {
        var newUser = Services.cs.Services.RegisterNewUser(DataBase.Users);

        Console.WriteLine("1. See your Info.\n2. Select a movie from the list.");
        int newUserAction = int.Parse(Console.ReadLine());

        if (newUserAction == 1)
        {
            Helpers.cs.Models.Members.DisplayInfoForUser(DataBase.Users, newUser.Username);

        }
        else if (newUserAction == 2)
        {
            Helpers.cs.Helpers.SelectMovieFromList(DataBase.Movies);

            Console.WriteLine("Which one would you like to rent?");
            int userInputRentMovieNumber = int.Parse(Console.ReadLine());
    
            Helpers.cs.Helpers.RentMovieFromList(DataBase.Movies, userInputRentMovieNumber);           
        }
        else
        {
            Console.WriteLine("Please enter a valid number!");
        }
    }
    else
    {
        Console.WriteLine("You did not enter a valid number!");
    }
}
else
{
    Console.WriteLine("You did not enter a valid number!");
}

Console.ReadLine();