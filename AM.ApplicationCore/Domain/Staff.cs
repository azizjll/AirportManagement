using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {

        public FullName Name { get; set; }


        public int StaffId { get; set; }
        public DateTime  EmployementDate { get; set; }

        public string Function { get; set; }

        [DataType(DataType.Currency)]  // Format monétaire
        public float Salary { get; set; }


        public override void PassengerType ()
        {
            Console.WriteLine("I am a staff");
        }

        public Staff(string firstName, string lastName, string email, DateTime birthDate, DateTime employementDate, float salary)
        {
            Name = new FullName(firstName, lastName);
            EamilAdress = email;
            BirthDate = birthDate;
            EmployementDate = employementDate;
            Salary = salary;
        }

    }
}
