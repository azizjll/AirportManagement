using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; } // Propriété de clé primaire

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]  // Afficher comme "Date of Birth"
        [Required]  // Propriété requise
        public DateTime BirthDate { get; set; }

        [StringLength(7)]  // La longueur de 7 caractères
        public string? PassportNumber { get; set; }

        [EmailAddress]  // Valider l'adresse email
        public string? EamilAdress { get; set; }

        public FullName Name { get; set; }

        [RegularExpression(@"^\d{8}$", ErrorMessage = "Phone number must be 8 digits.")]
        public string? TelNumber { get; set; }
        public ICollection<Flight>? Flights { get; set; }


        //public bool CheckProfile(string nom,string prenom)
        //{
        //    bool resultat;
        //    if (!nom.Equals(prenom))
        //    {
        //        resultat = true;
        //    }
        //    else {
        //        resultat = false;
        //    }
        //    return resultat;
        //}

        //public bool CheckProfile(string nom, string prenom,string email)
        //{
        //    bool resultat;
        //    if (!nom.Equals(prenom) && email != null)
        //    {
        //        resultat = true;
        //    }
        //    else
        //    {
        //        resultat = false;
        //    }

        //    return resultat;
        //}

            public bool CheckProfile(string nom, string prenom, string? email=null)
            {
            bool resultat;
            if (nom.Equals(this.Name.LastName) && prenom.Equals(this.Name.FirstName) && email != null && email.Equals(this.EamilAdress) || nom.Equals(this.Name.LastName) && prenom.Equals(this.Name.FirstName) && email == null)
            {
                resultat = true;
            }
            else
            {
                resultat = false;
            }
            return resultat;
        }


        public override string ToString( ) {
            return this.Name.LastName + " " + this.Name.FirstName + " " + this.EamilAdress;
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }


    }
}
