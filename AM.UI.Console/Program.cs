// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, 4SAE5!");

//Plan plan1 = new Plan();
//plan1.Capacity = 200;
//plan1.PlaneId = 5;
//plan1.ManufactureDate = DateTime.Now;
//plan1.PlaneType = (int)PlanType.Boing;

//Console.WriteLine(plan1.ToString());

//Plan plan2 = new Plan(50,DateTime.Now,PlanType.irbus);
//Console.WriteLine(plan2.ToString());

//Passenger passenger = new Passenger();
//passenger.FirstName = "aziz";
//passenger.LastName = "chahlaoui";
//passenger.EamilAdress = "aziz@gmail.com";


//Console.WriteLine("P: " +passenger.ToString());

//Console.WriteLine("P check:" + passenger.CheckProfile("chahlaoui","aziz"));

//Console.WriteLine("P check:" + passenger.CheckProfile("chahlaoui", "aziz","test"));

//Passenger P1 = new Passenger();


//P1.PassengerType();

//Staff staff = new Staff();
//Travel travel = new Travel();
//staff.PassengerType();
//travel.PassengerType();
var flightService = new FlightMethods();
flightService.Flights = TestData.Flights;

// Afficher les informations sur les vols
foreach (var flight in flightService.Flights)
{
    Console.WriteLine($"Flight ID: {flight.FlightId}, Designation: {flight.Designation}, Departure: {flight.Departure}, Effective Arrival: {flight.EffectiveArrival}, Estimated Duration: {flight.EstimatedDuration}");
}

var dates = flightService.GetFlightDates("Paris");
Console.WriteLine("Dates de vols pour Paris :");
foreach (var date in dates)
{
    Console.WriteLine(date);
}

// Test de GetFlights
Console.WriteLine("Vols à destination de Paris :");
flightService.GetFlights("Destination", "Paris");

// 9. Test de GetFlightDatesUsingLINQ
var datesLINQ = flightService.GetFlightDatesUsingLINQ("Paris");
Console.WriteLine("Dates de vols pour Paris (LINQ) :");
foreach (var date in datesLINQ)
{
    Console.WriteLine(date);
} // 11. Test de ProgrammedFlightNumber
DateTime startDate = new DateTime(2022, 1, 1);
int flightCount = flightService.ProgrammedFlightNumber(startDate);
Console.WriteLine($"Nombre de vols programmés à partir du {startDate.ToShortDateString()} : {flightCount}");

// 12. Test de DurationAverage
double averageDuration = flightService.DurationAverage("Paris");
Console.WriteLine($"Durée moyenne des vols vers Paris : {averageDuration}");

// 13. Test de OrderedDurationFlights
var orderedFlights = flightService.OrderedDurationFlights();
Console.WriteLine("Vols ordonnés par durée estimée :");
foreach (var flight in orderedFlights)
{
    Console.WriteLine($"Flight ID: {flight.FlightId}, Duration: {flight.EstimatedDuration}");
}


// 14. Test de SeniorTravellers
var flightForSeniorTest = TestData.Flights.First(); // Prendre un vol pour le test
var seniorTravellers = flightService.SeniorTravellers(flightForSeniorTest);
Console.WriteLine("3 passagers les plus âgés :");
foreach (var traveller in seniorTravellers)
{
    Console.WriteLine($"{traveller.Name.FirstName} {traveller.Name.LastName}");
}

// 15. Test de DestinationGroupedFlights
Console.WriteLine("Vols groupés par destination :");
flightService.DestinationGroupedFlights();