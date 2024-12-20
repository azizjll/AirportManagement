using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string? Designation { get; set; }
        public string? Departure { get; set; }
        public DateTime FlightDate { get; set; }

        [Key]
        public int FlightId { get; set; }

        [ForeignKey("Plane")]
        public int? PlaneId { get; set; }

        public DateTime EffectiveArrival { get; set; }

        public float EstimatedDuration { get; set; }

        //public string Airline { get; set; }


        public Plan? Plan { get; set; }

        public ICollection<Passenger>? Passengers { get; set; }
    }
}
