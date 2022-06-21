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
    internal class InstructorCourseRepository : IInstructorCourseRepository
    {
        public Task<Tuple<InstructorCourse, bool>> AddAsync(InstructorCourse entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InstructorCourse>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<InstructorCourse>> GetByFilterAsync(Expression<Func<InstructorCourse, bool>> expressionFilter = null)
        {
            throw new NotImplementedException();
        }

        public Task<InstructorCourse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<InstructorCourse, bool>> UpdateAsync(InstructorCourse entity)
        {
            throw new NotImplementedException();
        }
    }
}
