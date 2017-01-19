using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peter.Models.Repositories
{
    interface IPersonRepository
    {
        Person GetPerson(int id);
        List<Person> Persons();
    }
}