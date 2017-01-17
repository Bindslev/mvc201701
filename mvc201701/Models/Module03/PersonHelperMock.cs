using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc201701.Models.Module03
{
    public class PersonHelperMock : IPersonHelper
    {
        public Person GetPerson(int id)
        {
            Person p = new Person() { Id = id, Name = "MOCK MOCK", BirthDate = DateTime.Now };
            return p;

        }
    }
}