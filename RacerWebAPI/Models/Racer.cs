namespace RacerWebAPI.Models
{
    public class Racer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Country { get; set; }

        public int Wins { get; set; }

        public Racer() { }

        public Racer(int id, string firstName, string lastName, string country, int wins)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            Wins = wins;
        }
        public override string ToString() => $" Id = {Id} , FirstName = {FirstName}  ,LastName ={LastName}  , Country = {Country}  Wins = {Wins} ";
    }
}
