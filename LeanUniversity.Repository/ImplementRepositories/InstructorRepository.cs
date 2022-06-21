using LeanUniversity.Contracts.Repository;
using LeanUniversity.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeanUniversity.Repository.ImplementRepositories
{
    public class InstructorRepository : IInstructorRepository
    {
        public Task<Tuple<Instructor, bool>> AddAsync(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Instructor>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Instructor>> GetByFilterAsync(Expression<Func<Instructor, bool>> expressionFilter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Instructor> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<Instructor, bool>> UpdateAsync(Instructor entity)
        {
            throw new NotImplementedException();
        }
    }
}
