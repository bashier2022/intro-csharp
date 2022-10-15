using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteProject
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }

        public List<RegCourse> Courses { get; set; }

    }

    public class RegCourse
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public int Status { get; set; }
        public int Grade { get; set; }

    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
    }

    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EMail { set; get; }
        public string Room { set; get; }

        public List<Course> Teaches { get; set; }
    }
    public class SchoolDb : DbContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<RegCourse> RegesteredCourses { get; set; }

        DbSet<Lecturer> Teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\qafza2022\intro-csharp\lesson-17\schoolDb.db");
        }

    }
}
