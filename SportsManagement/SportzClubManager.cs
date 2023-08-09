using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagement
{
    internal class SportzClubManager
    {
        private List<Athlete> athletes = new List<Athlete>();
        private List<Event> events = new List<Event>();

        public int RegisterAthlete(string firstName, string lastName, int age, string sport, DateTime registrationDate)
        {
            int athleteId = athletes.Count > 0 ? athletes.Max(a => a.AthleteId) + 1 : 1;
            athletes.Add(new Athlete
            {
                AthleteId = athleteId,
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Sport = sport,
                RegistrationDate = registrationDate
            });
            return athleteId;
        }

        public string ViewAthleteDetails(int athleteId)
        {
            var athlete = athletes.FirstOrDefault(a => a.AthleteId == athleteId);
            if (athlete != null)
            {
                return $"Name: {athlete.FirstName} {athlete.LastName}\nAge: {athlete.Age}\nSport: {athlete.Sport}\nRegistration Date: {athlete.RegistrationDate}";
            }
            return "Athlete not found.";
        }

        public string UpdateAthleteDetails(int athleteId, string firstName, string lastName, int age, string sport)
        {
            var athlete = athletes.FirstOrDefault(a => a.AthleteId == athleteId);
            if (athlete != null)
            {
                athlete.FirstName = firstName;
                athlete.LastName = lastName;
                athlete.Age = age;
                athlete.Sport = sport;
                return "Update successful.";
            }
            return "Athlete not found.";
        }

        public string RemoveAthlete(int athleteId)
        {
            var athlete = athletes.FirstOrDefault(a => a.AthleteId == athleteId);
            if (athlete != null)
            {
                athletes.Remove(athlete);
                return "Athlete removed successfully.";
            }
            return "Athlete not found.";
        }
    }
}
