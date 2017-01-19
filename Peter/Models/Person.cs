using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Peter.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Registered { get; set; }
    }
}