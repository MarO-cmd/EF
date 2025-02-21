using Castle.DynamicProxy.Contributors;
using EF_Project.Configurations;
using EF_Project.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project.Contexts
{
    internal class MyAppDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server= .; Database = RouteEF ;Trusted_Connection = true");
        }

        public DbSet<Student> Students{ get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Instructor> Instructors{ get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Topic> Topics{ get; set; }

       // public DbSet<Course_Instructor> Course_Instructors { get; set; }
       // DbSet<Student_Course> Student_Courses { get; set; }





    }
}
