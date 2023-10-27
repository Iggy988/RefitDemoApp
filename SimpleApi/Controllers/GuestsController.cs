using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GuestsController : ControllerBase
{
    private static List<GuestModel> guests = new()
    {
        new GuestModel {Id = 1, FirstName = "Pero", LastName = "Peric"},
        new GuestModel {Id = 2, FirstName = "Djoko", LastName = "Djokic"},
        new GuestModel {Id = 3, FirstName = "Marko", LastName = "Markovic"},
    };


    // GET: api/<GuestsController>
    [HttpGet]
    public IEnumerable<GuestModel> Get()
    {
        return guests;
    }

    // GET api/<GuestsController>/5
    [HttpGet("{id}")]
    public GuestModel Get(int id)
    {
        return guests.Where(g => g.Id == id).FirstOrDefault();
    }

    // POST api/<GuestsController>
    [HttpPost]
    public void Post([FromBody] GuestModel value)
    {
        guests.Add(value);
    }

    // PUT api/<GuestsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] GuestModel value)
    {
        //brisemo postojeci element i stavljamo novi
        guests.Remove(guests.Where(g =>g.Id == id).FirstOrDefault());
        guests.Add(value);
    }

    // DELETE api/<GuestsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        guests.Remove(guests.Where(g => g.Id == id).FirstOrDefault());
    }
}
