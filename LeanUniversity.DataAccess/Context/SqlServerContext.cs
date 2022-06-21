using LeanUniversity.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanUniversity.DataAccess.Context
{
    public class SqlServerContext: DbContext
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<InstructorCourse> InstructorCourse { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Student> Student { get; set; }

        public readonly string _connectionString=string.Empty;

        public SqlServerContext()
        {
            _connectionString = @"Data Source = DESKTOP-R4U1A54\SQLEXPRESS; Initial Catalog = LeanUniversity; Integrated Security = true";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasKey(e => new { e.IdCourse });
            modelBuilder.Entity<Course>().Property(e => e.IdCourse).UseIdentityColumn().Metadata.SetBeforeSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            modelBuilder.Entity<InstructorCourse>().HasKey(e => new { e.IdInstructorCourse });
            modelBuilder.Entity<InstructorCourse>().Property(e => e.IdInstructorCourse).UseIdentityColumn().Metadata.SetBeforeSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            modelBuilder.Entity<StudentCourse>().HasKey(e => new { e.IdStudentCourse });
            modelBuilder.Entity<StudentCourse>().Property(e => e.IdStudentCourse).UseIdentityColumn().Metadata.SetBeforeSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            modelBuilder.Entity<Instructor>().HasKey(e => new { e.IdInstructor });
            modelBuilder.Entity<Instructor>().Property(e => e.IdInstructor).UseIdentityColumn().Metadata.SetBeforeSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            modelBuilder.Entity<Student>().HasKey(e => new { e.IdStudent });
            modelBuilder.Entity<Student>().Property(e => e.IdStudent).UseIdentityColumn().Metadata.SetBeforeSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            base.OnModelCreating(modelBuilder);

        }


    }
}
