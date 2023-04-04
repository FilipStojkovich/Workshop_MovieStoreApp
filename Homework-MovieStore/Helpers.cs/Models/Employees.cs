using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.cs.Models
{
    public class Employees : Members
    {
        public Employees()
        {

        }
        
        public Employees(int hoursPerMonth)
        {
            HoursPerMonth = hoursPerMonth;
        }
        
        
        private int Salary { get; set; } = 300;
        public int HoursPerMonth { get; set; }
        public double Bonus { get; set; }


        public void SetBonus(Employees employee)
        {
            if (employee.HoursPerMonth > 160)
            {
                employee.Bonus = 0.3;
            }
            else
            {
                employee.Bonus = 0;
            }
        }

        public void SetSalary(Employees employee)
        {
            employee.Salary = (int)(employee.HoursPerMonth * employee.Bonus);
        }
    }
}
