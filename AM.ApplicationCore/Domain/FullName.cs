using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructeur sans paramètre, nécessaire pour les types complexes
        public FullName() { }

        // Constructeur avec paramètre
        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

}
