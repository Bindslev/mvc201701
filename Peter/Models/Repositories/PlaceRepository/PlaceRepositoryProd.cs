using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Peter.Models.Repositories
{
    public class PlaceRepositoryProd : IPlaceRepository
    {
        public Place GetPlace()
        {
            Place pl = new Place() { Planet = "Earth", Country = "Denmark", City = "Taastrup" };
            return pl;
        }
    }
}