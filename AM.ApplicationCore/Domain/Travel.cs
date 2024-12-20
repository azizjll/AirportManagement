using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Travel:Passenger
    {
        public FullName Name { get; set; }

        public String Nationality { get; set; }

        public String HealthInformation { get; set; }


        public override void PassengerType()
        {
            Console.WriteLine("I am a travel");
        }

        public Travel(string firstName, string lastName, string email, DateTime birthDate, string healthInformation, string nationality)
        {
            Name = new FullName(firstName, lastName);
            EamilAdress = email;
            BirthDate = birthDate;
            HealthInformation = healthInformation;
            Nationality = nationality;
        }


    }
}
