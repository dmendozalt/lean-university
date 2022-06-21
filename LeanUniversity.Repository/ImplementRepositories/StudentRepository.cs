using LeanUniversity.Contracts.Repository;
using LeanUniversity.DataAccess.Context;
using LeanUniversity.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeanUniversity.Repository.ImplementRepositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SqlServerContext _context;

        public StudentRepository()
        {
            _context = new SqlServerContext();
        }

        public async Task<Tuple<Student, bool>> AddAsync(Student entity)
        {
            try
            {
                var result = _context.Student.Add(entity);
                await _context.SaveChangesAsync();
                return Tuple.Create(result.Entity, true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Student>> GetAllAsync()
        {
            try
            {
                var result = await _context.Student.ToListAsync();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Student>> GetByFilterAsync(Expression<Func<Student, bool>> expressionFilter = null)
        {
            try
            {
                return await _context.Student.Where<Student>(expressionFilter).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Student.FindAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Tuple<Student, bool>> UpdateAsync(Student entity)
        {
            try
            {
                var result = _context.Student.Update(entity);
                await _context.SaveChangesAsync();
                return Tuple.Create(result.Entity, true);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
