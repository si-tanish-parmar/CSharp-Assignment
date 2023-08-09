using RacerWebAPI.Models;
namespace RacerWebAPI.Repository


{
    public interface IRacerRepository
    {
        List<Racer> GetRacers();
        Racer GetRacer(int id);
        Racer AddRacer(Racer racer);
        Racer UpdatRacer(Racer racer);
        bool DeleteRacer(Racer racer);
    }
}
