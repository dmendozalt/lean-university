using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanUniversity.Entities.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string City  { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public int Status { get; set; }
    }
}
