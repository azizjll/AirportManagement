using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        // Implémentation des méthodes ici
        //public List<DateTime> GetFlightDates(string destination)
        //{
        //    List<DateTime> flightDates = new List<DateTime>();

        //    for (int i = 0; i < Flights.Count; i++)
        //    {
        //        if (Flights[i].Designation.Equals(destination, StringComparison.OrdinalIgnoreCase))
        //        {
        //            flightDates.Add(Flights[i].FlightDate);
        //        }
        //    }

        //    return flightDates;
        //}
        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> flightDates = new List<DateTime>();

            foreach (var flight in Flights)
            {
                if (flight.Designation.Equals(destination, StringComparison.OrdinalIgnoreCase))
                {
                    flightDates.Add(flight.FlightDate);
                }
            }

            return flightDates;
        }
        public void GetFlights(string filterType, string filterValue)
        {
            foreach (var flight in Flights)
            {
                switch (filterType.ToLower())
                {
                    case "destination":
                        if (flight.Designation.Equals(filterValue, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Flight ID: {flight.FlightId}, Destination: {flight.Designation}, Departure: {flight.Departure}, Flight Date: {flight.FlightDate}");
                        }
                        break;

                    case "designation":
                        if (flight.Designation.Equals(filterValue, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Flight ID: {flight.FlightId}, Designation: {flight.Designation}, Departure: {flight.Departure}, Flight Date: {flight.FlightDate}");
                        }
                        break;

                    // Ajoutez d'autres filtres selon vos besoins
                    // case "effectivearrival":
                    //     if (flight.EffectiveArrival.Equals(filterValue, StringComparison.OrdinalIgnoreCase))
                    //     {
                    //         Console.WriteLine($"Flight ID: {flight.FlightId}, Effective Arrival: {flight.EffectiveArrival}, Flight Date: {flight.FlightDate}");
                    //     }
                    //     break;

                    default:
                        Console.WriteLine("Type de filtre non valide.");
                        break;
                }
            }
        }
        // 9. Reformuler GetFlightDates en utilisant LINQ
        public List<DateTime> GetFlightDatesUsingLINQ(string destination)
        {
            var flightDates = Flights
                .Where(f => f.Designation.Equals(destination, StringComparison.OrdinalIgnoreCase))
                .Select(f => f.FlightDate)
                .ToList();

            return flightDates;
        }
        // 10. Afficher les dates et les destinations des vols d’un avion passé en paramètre
        public void ShowFlightDetails(Plan plane)
        {
            var flightDetails = Flights
                .Where(f => f.Plan.PlaneId == plane.PlaneId)
                .Select(f => new { f.FlightDate, f.Designation });

            foreach (var detail in flightDetails)
            {
                Console.WriteLine($"Destination: {detail.Designation}, Date: {detail.FlightDate}");
            }
        }

        // 11. Retourner le nombre de vols programmés pour une semaine à partir d’une date donnée
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var flightCount = Flights
                .Count(f => f.FlightDate >= startDate && f.FlightDate < startDate.AddDays(7));
            return flightCount;
        }

        // 12. Retourner la moyenne de durée estimée des vols d’une destination donnée
        public double DurationAverage(string destination)
        {
            var averageDuration = Flights
                .Where(f => f.Designation.Equals(destination, StringComparison.OrdinalIgnoreCase))
                .Average(f => f.EstimatedDuration);
            return averageDuration;
        }

        // 13. Retourner les vols ordonnés par EstimatedDuration du plus long au plus court
        public List<Flight> OrderedDurationFlights()
        {
            return Flights
                .OrderByDescending(f => f.EstimatedDuration)
                .ToList();
        }

        // 14. Retourner les 3 passagers les plus âgés d’un vol
        public List<Passenger> SeniorTravellers(Flight flight)
        {
            // Vérifier si la collection Passengers est null
            if (flight.Passengers == null)
            {
                return new List<Passenger>(); // Retourner une liste vide si elle est null
            }

            return flight.Passengers
                .OrderByDescending(p => p.BirthDate)
                .Take(3)
                .ToList();
        }

        // 15. Retourner les vols groupés par destination
        public void DestinationGroupedFlights()
        {
            var groupedFlights = Flights
                .GroupBy(f => f.Designation)
                .Select(g => new { Destination = g.Key, Flights = g.ToList() });

            foreach (var group in groupedFlights)
            {
                Console.WriteLine($"Destination: {group.Destination}");
                foreach (var flight in group.Flights)
                {
                    Console.WriteLine($"Décollage : {flight.FlightDate}");
                }
            }
        }
    
}
}
