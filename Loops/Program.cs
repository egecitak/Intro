namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] courses = new string[]
            {
                "Java",
                "Python",
                "C#"
            };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}