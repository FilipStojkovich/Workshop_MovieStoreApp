using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Helpers.cs.Models
{
    public class Members
    {
        public Members()
        {

        }
        
        public Members(string firstName, string lastName, int age, string userName, string passWord, string phoneNumber, DateTime dateOfRegistration, Roles role)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Username = userName;
            Password = passWord;
            PhoneNumber = String.Format("{0:##,###,###}", phoneNumber);
            DateOfRegistration = dateOfRegistration;
            Role = role;
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Roles Role { get; set; }
        

        public static void DisplayInfo(Users user)
        {
            Console.WriteLine($"User: {user.FirstName} {user.LastName} | Registered on: {user.DateOfRegistration} | Subscription: {user.Subscription}");
        }

        public static void DisplayInfoForUser(List<Users> user, string name)
        {
            user.Where(user => user.Username == name).ToList()
                .ForEach(user => Console.WriteLine
                ($"User: {user.FirstName} {user.LastName} | Registered on: {user.DateOfRegistration} | Subscription: {user.Subscription}"));
        }
    }
}
