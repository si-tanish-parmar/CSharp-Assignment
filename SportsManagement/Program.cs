namespace SportsManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportzClubManager clubManager = new SportzClubManager();

           
            int athlete1Id = clubManager.RegisterAthlete("Tanish", "Parmar", 22, "Cricket", DateTime.Now);
            int athlete2Id = clubManager.RegisterAthlete("Harsh", "Sanas", 21, "Football", DateTime.Now);

            Console.WriteLine("Athlete Details:");
            Console.WriteLine(clubManager.ViewAthleteDetails(athlete1Id));
            Console.WriteLine();
            Console.WriteLine(clubManager.ViewAthleteDetails(athlete2Id));
            Console.WriteLine();

            int event1Id = clubManager.CreateEvent("Cricket", "Tournament", DateTime.Now);
            int event2Id = clubManager.CreateEvent("Football", "Tournament", DateTime.Now);

            Console.WriteLine("Event Details:");
            Console.WriteLine(clubManager.ViewEventDetails(event1Id));
            Console.WriteLine();
            Console.WriteLine(clubManager.ViewEventDetails(event2Id));
            Console.WriteLine();

            clubManager.AthletePerformance(athlete1Id, event1Id, "101*(89) ", DateTime.Now);
            clubManager.AthletePerformance(athlete2Id, event2Id, "5-4 ", DateTime.Now);


            Console.WriteLine("View Performance:");
            Console.WriteLine(clubManager.ViewAthletePerformance(athlete1Id));
            Console.WriteLine(clubManager.ViewAthletePerformance(athlete2Id));
        }
    }
}
