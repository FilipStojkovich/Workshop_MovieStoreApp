using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.cs.Models
{
    public class Users : Members
    {
        public Users()
        {

        }

        public Users(int memberNumber, Subscription subscription)
        {
            MemberNumber = memberNumber;
            Subscription = subscription;
        }

        public int MemberNumber { get; set; }
        public Subscription Subscription { get; set; }
    }
}
