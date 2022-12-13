using Microsoft.AspNetCore.Mvc;
using SuperHeroDotNetSevenApi.Services.SuperHeroService;

namespace SuperHeroDotNetSevenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public SuperHeroController(ISuperHeroService superHeroService)
        {
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return Ok(superHeros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var hero = superHeros.Find(x => x.Id == id);
            if (hero is null)
            {
                return NotFound("Sorry, but this hero doesen't exist.");
            }
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        { 
            superHeros.Add(hero);
            return Ok(superHeros);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id,SuperHero request)
        {
            var hero = superHeros.Find(x => x.Id == id);
            if (hero is null)
            {
                return NotFound("Sorry, but this hero doesen't exist.");
            }

            hero.Name= request.Name;
            hero.FirstName= request.FirstName;
            hero.LastName= request.LastName;
            hero.Place= request.Place;

            return Ok(superHeros);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
        
        }
    }
}
