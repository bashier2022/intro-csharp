namespace DbModel
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Birthyear { get; set; }
        public int Email { get; set; }

        public List<Course> Courses { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

    }
    public class AbsolvatedCourses
    {
        public int PersonId { get; set; }
        public int CourseId { get; set; }
        public int Mark { get; set; }
    }
    
}