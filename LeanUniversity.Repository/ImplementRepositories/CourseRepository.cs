using LeanUniversity.Contracts.Generics;
using LeanUniversity.Contracts.Repository;
using LeanUniversity.DataAccess.Context;
using LeanUniversity.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeanUniversity.Repository.ImplementRepositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SqlServerContext _context;

        public CourseRepository()
        {
            this._context = new SqlServerContext();
        }
        public async Task<Tuple<Course, bool>> AddAsync(Course entity)
        {
            try
            {
                var result = _context.Course.Add(entity);
                await _context.SaveChangesAsync();
                return Tuple.Create(result.Entity, true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Course>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Course>> GetByFilterAsync(Expression<Func<Course, bool>> expressionFilter)
        {
            throw new NotImplementedException();
        }

        public async Task<Course> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Tuple<Course, bool>> UpdateAsync(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
