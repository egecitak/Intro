namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Engin Demiroğ";
            course1.WatchRate = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Instructor = "Kerem Varış";
            course2.WatchRate = 48;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Instructor = "Berkay Bilgin";
            course3.WatchRate = 30;

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (Course course in courses)
            {
                Console.WriteLine($"{course.CourseName}: {course.Instructor} {course.WatchRate}%");
            }
        }
    }

    class Course
    {
        //prop
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int WatchRate { get; set; }
    }
}