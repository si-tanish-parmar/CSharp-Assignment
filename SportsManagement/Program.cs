namespace SportsManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportzClubManager clubManager = new SportzClubManager();

            // Register Athletes
            int athlete1Id = clubManager.RegisterAthlete("Tanish", "Parmar", 22, "Cricket", DateTime.Now);
            int athlete2Id = clubManager.RegisterAthlete("Harsh", "Sanas", 21, "Basketball", DateTime.Now);

            // View Athlete Details
            Console.WriteLine("Athlete Details:");
            Console.WriteLine(clubManager.ViewAthleteDetails(athlete1Id));
            Console.WriteLine(clubManager.ViewAthleteDetails(athlete2Id));
            Console.WriteLine();


        }
    }
}