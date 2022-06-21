using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanUniversity.Entities.Entities
{
    public class Instructor: Person
    {
        public int IdInstructor { get; set; }
        public string Speciality { get; set; }
    }
}
