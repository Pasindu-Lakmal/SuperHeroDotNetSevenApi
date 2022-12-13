namespace SuperHeroDotNetSevenApi.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeros = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1,
                Name = "Spider Man",
                FirstName = "Peter",
                LastName = "Parker",
                Place ="New York City"
            },
            new SuperHero
            {
                Id = 2,
                Name = "Iron Man",
                FirstName = "Tony",
                LastName = "Stark",
                Place ="Malibu"
            }
        };


        public List<SuperHero> AddHero(SuperHero hero)
        {
            throw new NotImplementedException();
        }

        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeros.Find(x => x.Id == id);
            if (hero is null)
            {

                return null;
            }

            superHeros.Remove(hero);

            return superHeros;
        }

        public SuperHero GetSingleHero(int id)
        {
            throw new NotImplementedException();
        }

        public List<SuperHero> GetSuperHeroes()
        {
            throw new NotImplementedException();
        }

        public List<SuperHero> UpdateHero(int id, SuperHero hero)
        {
            throw new NotImplementedException();
        }
    }
}
