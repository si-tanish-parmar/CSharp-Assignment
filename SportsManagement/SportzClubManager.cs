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
        private List<Performance> performances = new List<Performance>();
        private int nextEventId = 1;

        public int RegisterAthlete(string firstName, string lastName, int age, string sport, DateTime registrationDate)
        {
            int athleteId;

            if (athletes.Count > 0)
            {
                athleteId = athletes.Max(a => a.AthleteId) + 1;
            }
            else
            {
                athleteId = 1;
            }

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
            Athlete athlete = null;
            foreach (var a in athletes)
            {
                if (a.AthleteId == athleteId)
                {
                    athlete = a;
                    break;
                }
            }

            if (athlete != null)
            {
                return $"Name: {athlete.FirstName} {athlete.LastName}\nAge: {athlete.Age}\nSport: {athlete.Sport}\nRegistration Date: {athlete.RegistrationDate}";
            }
            return "Athlete not found.";
        }

        public string UpdateAthleteDetails(int athleteId, string firstName, string lastName, int age, string sport)
        {
            Athlete athlete = null;
            foreach (var a in athletes)
            {
                if (a.AthleteId == athleteId)
                {
                    athlete = a;
                    break; // Exit the loop once a match is found
                }
            }

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
            Athlete athlete = null;
            foreach (var a in athletes)
            {
                if (a.AthleteId == athleteId)
                {
                    athlete = a;
                    break; // Exit the loop once a match is found
                }
            }
            if (athlete != null)
            {
                athletes.Remove(athlete);
                return "Athlete removed successfully.";
            }
            return "Athlete not found.";
        }

        public int CreateEvent(string eventName, string eventType, DateTime eventDate)
        {
            int eventId = nextEventId; // Use the next available ID

            events.Add(new Event
            {
                EventId = eventId,
                EventName = eventName,
                EventType = eventType,
                EventDate = eventDate
            });

            nextEventId++; // Increment for the next event
            return eventId;
        }

        public string ViewEventDetails(int eventId)
        {
            Event eventData = null;
            foreach (var e in events)
            {
                if (e.EventId == eventId)
                {
                    eventData = e;
                    break;
                }
            }

            if (eventData != null)
            {
                return $"Event Name: {eventData.EventName}\nEvent Type: {eventData.EventType}\nEvent Date: {eventData.EventDate}";
            }
            return "Event not found.";
        }

        public string UpdateEventDetails(int eventId, string eventName, string eventType, DateTime eventDate)
        {
            Event eventData = null;
            foreach (var a in events)
            {
                if (a.EventId == eventId)
                {
                    eventData = a;
                    break; // Exit the loop once a match is found
                }
            }

            if (eventData != null)
            {
                eventData.EventName = eventName;
                eventData.EventType = eventType;
                eventData.EventDate = eventDate;

                return "Update successful.";
            }
            return "Event not found.";
        }
        public string RemoveEvent(int eventId)
        {
            Event eventData = null;
            foreach (var a in events)
            {
                if (a.EventId == eventId)
                {
                    eventData = a;
                    break; // Exit the loop once a match is found
                }
            }
            if (eventData != null)
            {
                events.Remove(eventData);
                return "Event removed successfully.";
            }
            return "Event not found.";
        }

        public void AthletePerformance(int eventId, int athleteId, string score, DateTime currentTime)
        {
            // Validate if eventId and athleteId are valid before proceeding
            bool validEvent = events.Any(e => e.EventId == eventId);
            bool validAthlete = athletes.Any(a => a.AthleteId == athleteId);

            if (!validEvent)
            {
                Console.WriteLine("Invalid EventId.");
                return;
            }

            if (!validAthlete)
            {
                Console.WriteLine("Invalid AthleteId.");
                return;
            }

            // Create a new Performance object and add it to the performances list
            performances.Add(new Performance
            {
                AthleteId = athleteId, // Assign the athlete ID
                Score = score,
                CurrentTime = currentTime
            });
        }

        public string ViewAthletePerformance(int athleteId)
        {
            string performanceDetails = "";
            Athlete athlete = null;
            foreach (var a in athletes)
            {
                if (a.AthleteId == athleteId)
                {
                    athlete = a;
                    break;
                }
            }

            if (athlete != null)
            {
                performanceDetails += $"Athlete: {athlete.FirstName} {athlete.LastName}\n";
                performanceDetails += "Performance:\n";

                var athletePerformances = performances.Where(p => p.AthleteId == athleteId);

                foreach (var performance in athletePerformances)
                {
                    performanceDetails += $"Score: {performance.Score}\n";
                    performanceDetails += $"Time: {performance.CurrentTime}\n";
                   
                }

                return performanceDetails;
            }
            return "Athlete not found.";





        }
    }
}



    

