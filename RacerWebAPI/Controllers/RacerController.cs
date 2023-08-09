using Microsoft.AspNetCore.Mvc;
using RacerWebAPI.Repository;
using RacerWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RacerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacerController : ControllerBase
    {
        RacerRepository repository = new RacerRepository();
        // GET: api/<RacerController>
        [HttpGet]
        public List<Racer> Get()
        {
            return repository.GetRacers();
        }

        // GET api/<RacerController>/5
        // GET api/<RacerController>/5
        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Racer> GetById(int id)
        {
            Racer emp = repository.GetRacer(id);
            if (emp == null)
            { return NotFound(); }
            return Ok(emp);
        }

        // POST api/<RacerController>
        [HttpPost]
        public ActionResult Post(Racer racer)
        {
            Racer r = repository.AddRacer(racer);
            if (r == null)
            {
                // POST api/<RacerController>
                [HttpPost]
                public ActionResult Post(Racer racer)
                {
                    Racer r = repository.AddRacer(racer);
                    if (r == null)
                    {
                        return BadRequest();
                    }
                    return Ok(CreatedAtRoute(nameof(GetById), new { id = r.Id }, r));

                }

                // PUT api/<RacerController>/5
                [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RacerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
