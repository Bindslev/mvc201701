using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Peter.Models.Repositories
{
    public class PersonRepositoryMock : IPersonRepository
    {
        public Person GetPerson(int id)
        {
            foreach (var item in Persons()) {
                if (item.Id == id) {
                    return item;
                }
            }
            return null;
        }

        public List<Person> Persons()
        {
            Person p1 = new Person() { Id = 1, Gender = Gender.Female, Name = "Test1", Registered = DateTime.Now };
            Person p2 = new Person() { Id = 2, Gender = Gender.Female, Name = "Test2", Registered = DateTime.Now };
            List<Person> lst = new List<Person>();
            lst.Add(p1);
            lst.Add(p2);
            return lst;
        }
    }
}