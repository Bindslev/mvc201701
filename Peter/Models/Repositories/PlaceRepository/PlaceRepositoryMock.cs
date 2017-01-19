using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Peter.Models.Repositories
{
    public class PlaceRepositoryMock : IPlaceRepository
    {
        public Place GetPlace()
        {
            Place pl = new Place() { Planet = "PlanetTest", Country = "CountryTest", City = "CityTest" };
            return pl;
        }
    }
}