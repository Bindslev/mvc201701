using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc201701.Models.Module03
{
    interface IPersonHelper
    {
        Person GetPerson(int id);
    }
}
