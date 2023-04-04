using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.cs.Models
{
    public class DataBase
    {
        public static List<Users> Users = new List<Users>()
        {
                new Users{FirstName = "Filip", LastName = "Stojkovich", Age = 25, Username = "FilipStojkovich", Password = "filipstojkovich", PhoneNumber = "071533554", DateOfRegistration = DateTime.Parse("17/10/2022"), Role = Roles.User ,MemberNumber = 1, Subscription = Subscription.Annually},
                new Users{FirstName = "Martin", LastName = "Ignov", Age = 24, Username = "MartinIgnov", Password = "martinignov", PhoneNumber = "075837393", DateOfRegistration = DateTime.Parse("22/12/2022"), Role = Roles.User , MemberNumber = 2, Subscription = Subscription.Monthly},
                new Users{FirstName = "Kristijan", LastName = "Jankulovski", Age = 23, Username = "KristijanJankulovski", Password = "kristijanjankulovski", PhoneNumber = "071233554", DateOfRegistration = DateTime.Parse("28/8/2021"), Role = Roles.User, MemberNumber = 3, Subscription = Subscription.Annually},
                new Users{FirstName = "Tosho", LastName = "Micevski", Age = 23, Username = "ToshoMicevski", Password = "toshomicevski", PhoneNumber = "071356954", DateOfRegistration = DateTime.Parse("07/02/2023"), Role = Roles.User, MemberNumber = 4, Subscription = Subscription.Monthly},
                new Users{FirstName = "Marija", LastName = "Spasova", Age = 27, Username = "MarijaSpasova", Password = "marijaspasova", PhoneNumber = "075023554", DateOfRegistration = DateTime.Parse("08/03/2022"), Role = Roles.User, MemberNumber = 5, Subscription = Subscription.Annually}
        };

        public static List<Employees> Employees = new List<Employees>()
        {
                new Employees{FirstName = "John", LastName = "Doe", Age = 25, Username = "JohnDoe", Password = "johndoe", PhoneNumber = "071777777", DateOfRegistration = new DateTime(01/01/2021), Role = Roles.Employee, HoursPerMonth = 165},
                new Employees{FirstName = "Bob", LastName = "Bobsky", Age = 35, Username = "BobBobsky", Password = "bobbobsky", PhoneNumber = "071837473", DateOfRegistration = new DateTime(10/05/2022), Role = Roles.Employee, HoursPerMonth = 140},
                new Employees{FirstName = "Walter", LastName = "White", Age = 42, Username = "WalterWhite", Password = "walterwhite", PhoneNumber = "075456531", DateOfRegistration = new DateTime(07/03/2021), Role = Roles.Employee, HoursPerMonth = 180},
                new Employees{FirstName = "Simon", LastName = "Riley", Age = 33, Username = "SimonRiley", Password = "simonriley", PhoneNumber = "075821758", DateOfRegistration = new DateTime(06/06/2022), Role = Roles.Employee, HoursPerMonth = 130},
                new Employees{FirstName = "Soap", LastName = "MacTavish", Age = 28, Username = "SoapMacTavish", Password = "soapmactavish", PhoneNumber = "071345634", DateOfRegistration = new DateTime(07/10/2023), Role = Roles.Employee, HoursPerMonth = 160}
        };

        public static List<Movies> Movies = new List<Movies>()
        {
                new Movies{Title = "Avatar", Description = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.", Year = 2009, Genre = Genres.Adventure, IsAvailableForRenting = true},
                new Movies{Title = "Titanic", Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.", Year = 1997, Genre = Genres.Drama, IsAvailableForRenting = true},
                new Movies{Title = "Shutter Island", Description = "In 1954, a U.S. Marshal investigates the disappearance of a murderer who escaped from a hospital for the criminally insane.", Year = 2010, Genre = Genres.Thriller, IsAvailableForRenting = true},
                new Movies{Title = "Ted 2", Description = "Newlywed couple Ted and Tami-Lynn want to have a baby, but in order to qualify to be a parent, Ted will have to prove he's a person in a court of law.", Year = 2015, Genre = Genres.Comedy, IsAvailableForRenting = true},
                new Movies{Title = "The Conjuring", Description = "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by a dark presence in their farmhouse.", Year = 2013, Genre = Genres.Horror, IsAvailableForRenting = false},
                new Movies{Title = "Black Panther: Wakanda Forever", Description = "The people of Wakanda fight to protect their home from intervening world powers as they mourn the death of King T'Challa.", Year = 2022, Genre = Genres.Action, IsAvailableForRenting = false}
        };
    }
}
