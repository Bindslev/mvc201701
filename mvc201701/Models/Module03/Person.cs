using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc201701.Models.Module03
{
    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public bool TestBool { get; set; }

        public Gender Gender { get; set; }
    }
}