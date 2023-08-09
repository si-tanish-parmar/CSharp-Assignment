using Microsoft.AspNetCore.Mvc;
using RacerWebAPI.Models;

namespace RacerWebAPI.Repository

{
    public class RacerRepository : IRacerRepository { 
    
        public List<Racer> racerList = new List<Racer>()
        {
            new Racer(){Id = 11,FirstName = "Niki", LastName = "Lauda",Country = "Austria", Wins = 15 },
             new Racer(){Id=12,FirstName="Joe",LastName="Hyden",Country="USA",Wins=30 },
              new Racer(){Id=13,FirstName="Zaroon",LastName="Stylus",Country="France",Wins=10 },
              new Racer(){Id=14,FirstName="Henry",LastName="Brad",Country="USA",Wins=40 },
              new Racer(){Id=15,FirstName="Nikil",LastName="Hyden",Country="France",Wins=10 }
        };
        //CRUD 
        //get racers

       
        [HttpGet]
        public List<Racer> GetRacers()
        {
           return racerList;
        }
    
        public Racer GetRacers(int id)
        {
            return racerList.SingleOrDefault(r => r.Id == id);
        }

        Racer IRacerRepository.AddRacer(Racer racer)
        {
            throw new NotImplementedException();
        }

        bool IRacerRepository.DeleteRacer(Racer racer)
        {
            throw new NotImplementedException();
        }

        Racer IRacerRepository.GetRacer(int id)
        {
            throw new NotImplementedException();
        }

        

        List<Racer> IRacerRepository.GetRacers()
        {
            throw new NotImplementedException();
        }

        Racer IRacerRepository.UpdatRacer(Racer racer)
        {
            throw new NotImplementedException();
        }
    }
}

