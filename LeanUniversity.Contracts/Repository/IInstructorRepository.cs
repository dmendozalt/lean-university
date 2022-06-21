using LeanUniversity.Contracts.Generics;
using LeanUniversity.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanUniversity.Contracts.Repository
{
    public interface IInstructorRepository: IGenericActionDbAddUpdate<Instructor>, IGenericActionDbQuery<Instructor>
    {
    }
}
