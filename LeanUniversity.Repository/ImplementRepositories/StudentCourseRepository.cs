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
    public class StudentCourseRepository : IStudentCourseRepository
    {
        public Task<Tuple<StudentCourse, bool>> AddAsync(StudentCourse entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentCourse>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentCourse>> GetByFilterAsync(Expression<Func<StudentCourse, bool>> expressionFilter = null)
        {
            throw new NotImplementedException();
        }

        public Task<StudentCourse> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Tuple<StudentCourse, bool>> UpdateAsync(StudentCourse entity)
        {
            throw new NotImplementedException();
        }
    }
}
