using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc201701.Models.Module03
{
    public class PersonHelper : IPersonHelper
    {
        public Person GetPerson(int id)
        {
            Person p = new Person() { Id = id, Gender= Gender.Male, Name = "Test", BirthDate = DateTime.Now };
            return p;
        }

        public List<Person> GetPersons()
        {
            Person p1 = new Person() { Id = 1, Gender = Gender.Male, Name = Guid.NewGuid().ToString(), BirthDate = DateTime.Now };
            Person p2 = new Person() { Id = 2, Gender = Gender.Male, Name = Guid.NewGuid().ToString(), BirthDate = DateTime.Now };
            List<Person> lst = new List<Person>();
            lst.Add(p1);
            lst.Add(p2);
            return lst;
        }
        public Person GetPersonError(int id)
        {
            object p = null;
            p.ToString();
            return null;
        }
    }
}