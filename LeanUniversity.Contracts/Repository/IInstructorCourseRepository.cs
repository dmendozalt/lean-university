using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeanUniversity.Contracts.Generics;
using LeanUniversity.Entities.Entities;

namespace LeanUniversity.Contracts.Repository
{
    public interface IInstructorCourseRepository: IGenericActionDbQuery<InstructorCourse>, IGenericActionDbAddUpdate<InstructorCourse>,IGenericActionDbDelete<InstructorCourse>
    {
    }
}
