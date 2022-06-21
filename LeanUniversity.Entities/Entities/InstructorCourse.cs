using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanUniversity.Entities.Entities
{
    public class InstructorCourse
    {
        public int IdInstructorCourse { get; set; }
        public int IdInstructor { get; set; }
        public int IdCourse { get; set; }
    }
}
