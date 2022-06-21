using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanUniversity.Entities.Entities
{
    public class StudentCourse
    {
        public int IdStudentCourse { get; set; }
        public int IdStudent { get; set; }
        public int IdCourse { get; set; }
    }
}
