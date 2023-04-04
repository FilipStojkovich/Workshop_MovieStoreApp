using Helpers.cs.Models;
using System.Data;
using System.Linq;

namespace Services.cs
{
    public class Services
    {

        public static Employees ValidateLogInEmployee(List<Employees> employees)
        {
            Console.WriteLine("Username:");
            string logInEmployeeUsername = Console.ReadLine();

            Console.WriteLine("Password:");
            string logInEmployeePassword = Console.ReadLine();

            var employee = employees.FirstOrDefault(employee => employee.Username == logInEmployeeUsername && employee.Password == logInEmployeePassword);

            if (employee == null)
                Console.WriteLine("Error: Username or Password is incorrect!");

            Console.WriteLine($"Welcome {employee.Username}!\nWhat would you like to do?(a/b/c/d)");

            return employee;
        }
        public static Users LogInUser(List<Users> users)
        {
            Console.WriteLine("Username:");
            string logInUserUsername = Console.ReadLine();

            Console.WriteLine("Password:");
            string logInUserPassword = Console.ReadLine();

            var user = users.FirstOrDefault(user => user.Username == logInUserUsername && user.Password == logInUserPassword);

            if (user == null)
                Console.WriteLine("User not found");

            Console.WriteLine($"Hello {user.Username}!\nWhat would you like to do?(1/2/3)");

            return user;
        }

        public static Users RegisterNewMember(List<Users> users)
        {
            Console.WriteLine("Enter First name:");
            string registerNewMemberFirstName = Console.ReadLine();

            Console.WriteLine("Enter Last name:");
            string registerNewMemberLastName = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            int registerNewMemberAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Username:");
            string registerNewMemberUserName = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string registerNewMemberPassWord = Console.ReadLine();

            Console.WriteLine("Enter Phone number:");
            string registerNewMemberPhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Subscription type:\n1.Monthly\n2.Annually");
            int registerNewMemberSubscriptionType = int.Parse(Console.ReadLine());

            users.Add(new Users
            {
                FirstName = registerNewMemberFirstName,
                LastName = registerNewMemberLastName,
                Age = registerNewMemberAge,
                Username = registerNewMemberUserName,
                Password = registerNewMemberPassWord,
                PhoneNumber = registerNewMemberPhoneNumber,
                DateOfRegistration = DateTime.Today,
                Role = Roles.User,
            });

            for (int i = 0; i < users.Count; i++)
            {
                if (registerNewMemberSubscriptionType == 1)
                {
                    users.LastOrDefault().Subscription = Subscription.Monthly;
                }
                else
                {
                    users.LastOrDefault().Subscription = Subscription.Annually;
                }
            }   

            Console.WriteLine($"{registerNewMemberUserName} has been added to the members. Do you want to see all members?(y/n)");
            string seeAllMembers = Console.ReadLine();

            if (seeAllMembers.ToLower() == "y")
            {
                foreach (Users user in users)
                {
                    Helpers.cs.Models.Members.DisplayInfo(user);
                }
            }
            else if (seeAllMembers.ToLower() == "n")
            {
                Console.WriteLine($"Got it. {registerNewMemberUserName} can now rent movies from the app!");
            }
            else
            {
                Console.WriteLine("Sorry. You did not enter a valid option!");
            }
            return users.LastOrDefault();
        }

        public static Users RegisterNewUser(List<Users> users)
        {
            Console.WriteLine("Enter First name:");
            string registerNewUserFirstName = Console.ReadLine();

            Console.WriteLine("Enter Last name:");
            string registerNewUserLastName = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            int registerNewUserAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Username:");
            string registerNewUserUserName = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string registerNewUserPassWord = Console.ReadLine();

            Console.WriteLine("Enter Phone number:");
            string registerNewUserPhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Subscription type:\n1.Monthly\n2.Annually");
            int registerNewUserSubscriptionType = int.Parse(Console.ReadLine());

            users.Add(new Users
            {
                FirstName = registerNewUserFirstName,
                LastName = registerNewUserLastName,
                Age = registerNewUserAge,
                Username = registerNewUserUserName,
                Password = registerNewUserPassWord,
                PhoneNumber = registerNewUserPhoneNumber,
                DateOfRegistration = DateTime.Today,
                Role = Roles.User,
            });

            for (int i = 0; i < users.Count; i++)
            {
                if (registerNewUserSubscriptionType == 1)
                {
                    users.LastOrDefault().Subscription = Subscription.Monthly;
                }
                else
                {
                    users.LastOrDefault().Subscription = Subscription.Annually;
                }
            }
            Console.WriteLine($"Welcome {registerNewUserUserName}!\nWhat would you like to do?(1/2)");

            return users.LastOrDefault();
        }

        public static void DeleteMembers(List<Users> users, int number)
        {            
            Console.WriteLine($"You have successfully deleted {users[number - 1].Username}");
            users.RemoveAt(number - 1);

            Console.WriteLine("Do you want to see the updated list of users?(Y/N)");
            string seeUpdatedListOfUsers = Console.ReadLine();

            if (seeUpdatedListOfUsers.ToLower() == "y")
            {
                foreach (Users user in users)
                {
                    Console.WriteLine($"Full name: {user.FirstName} {user.LastName} | Username: {user.Username}");
                }
            }
            else if (seeUpdatedListOfUsers.ToLower() == "n")
            {
                Console.WriteLine("Got it! Have a nice day.");
            }
            else
            {
                Console.WriteLine("Sorry. You did not enter a valid option!");
            }
        }
    }
}