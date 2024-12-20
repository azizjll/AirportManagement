using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class TestData
    {
        public static List<Plan> Planes = new List<Plan>
        {
              new Plan { PlaneType = PlanType.Boing, Capacity = 150, ManufactureDate = new DateTime(2015, 2, 3) },
              new Plan { PlaneType = PlanType.irbus, Capacity = 250, ManufactureDate = new DateTime(2020, 11, 11) } // Correction ici

        };

        public static List<Staff> StaffMembers = new List<Staff>
    {
        new Staff("Captain", "Captain", "Captain.captain@gmail.com", new DateTime(1965, 1, 1), new DateTime(1999, 1, 1), 99999),
        new Staff("Hostess1", "Hostess1", "hostess1.hostess1@gmail.com", new DateTime(1995, 1, 1), new DateTime(2020, 1, 1), 999),
        new Staff("Hostess2", "Hostess2", "hostess2.hostess2@gmail.com", new DateTime(1996, 1, 1), new DateTime(2020, 1, 1), 999)
    };

        public static List<Travel> Travellers = new List<Travel>
    {
        new Travel("Traveller1", "Traveller1", "Traveller1@gmail.com", new DateTime(1980, 1, 1), "No troubles", "American"),
        new Travel("Traveller2", "Traveller2", "Traveller2@gmail.com", new DateTime(1981, 1, 1), "Some troubles", "French"),
        new Travel("Traveller3", "Traveller3", "Traveller3@gmail.com", new DateTime(1982, 1, 1), "No troubles", "Tunisian"),
        new Travel("Traveller4", "Traveller4", "Traveller4@gmail.com", new DateTime(1983, 1, 1), "Some troubles", "American"),
        new Travel("Traveller5", "Traveller5", "Traveller5@gmail.com", new DateTime(1984, 1, 1), "Some troubles", "Spanish")
    };

        public static List<Flight> Flights = new List<Flight>
        {
            new Flight { FlightDate = new DateTime(2022, 1, 1, 15, 10, 10), Designation = "Paris", EffectiveArrival = new DateTime(2022, 1, 1, 17, 10, 10), Plan = Planes[1], EstimatedDuration = 110},
            new Flight { FlightDate = new DateTime(2022, 2, 1, 21, 10, 10), Designation = "Paris", EffectiveArrival = new DateTime(2022, 2, 1, 23, 10, 10), Plan = Planes[0], EstimatedDuration = 105 },
            new Flight { FlightDate = new DateTime(2022, 3, 1, 5, 10, 10), Designation = "Paris", EffectiveArrival = new DateTime(2022, 3, 1, 6, 40, 10), Plan = Planes[0], EstimatedDuration = 100 },
            new Flight { FlightDate = new DateTime(2022, 4, 1, 6, 10, 10), Designation = "Madrid", EffectiveArrival = new DateTime(2022, 4, 1, 8, 10, 10), Plan = Planes[0], EstimatedDuration = 130 },
            new Flight { FlightDate = new DateTime(2022, 5, 1, 17, 10, 10), Designation = "Madrid", EffectiveArrival = new DateTime(2022, 5, 1, 18, 50, 10), Plan = Planes[0], EstimatedDuration = 105 },
            new Flight { FlightDate = new DateTime(2022, 6, 1, 20, 10, 10), Designation = "Lisbonne", EffectiveArrival = new DateTime(2022, 6, 1, 22, 30, 10), Plan = Planes[1], EstimatedDuration = 200 }
        };
}
}
