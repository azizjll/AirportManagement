using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plan
    {
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive integer.")]
        public int Capacity { get; set; }
        public  DateTime ManufactureDate { get; set; }

        [Key] // Déclare que cette propriété est la clé primaire
        public int PlaneId { get; set; }
        public PlanType PlaneType { get; set; }

        public ICollection<Flight> Flights { get; set; }


        public Plan(int capacity, DateTime manufactureDate, PlanType planeType) 
        {
            this.Capacity = capacity;
            this.ManufactureDate = manufactureDate;
            this.PlaneType = planeType;
        }

        public Plan() { }
        public override string ToString()
        {
            return "PlanId = "+this.PlaneId +", Capacity= "+ this.Capacity+", PlaneType = "+this.PlaneType+ ", ManufactureDate= "+this.ManufactureDate;
        }

    }
}
