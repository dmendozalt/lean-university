using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanUniversity.Entities.Entities
{
    public class Student: Person
    {
        public int IdStudent { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
