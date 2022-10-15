using System.Data;

namespace SQLiteProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (SchoolDb db = new SchoolDb())
            {
                AddStudent(db);
                
                
               
            }

        }

        private static void AddStudent(SchoolDb db)
        {
            Student s1 = new Student() { Id = 26, FirstName = "Nezar", LastName = "Watted", EMail = "nezar@yahoo.com" };

            db.Add(s1);
            db.SaveChanges();
        }
    }
}