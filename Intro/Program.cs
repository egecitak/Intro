namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string categoryTag = "Category";
            int studentCount = 32000;
            double interest = 1.45;
            bool systemEntry = false;
            double dollarYesterday = 7.35;
            double dollarToday = 7.45;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Down button");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("Up button");
            }
            else
            {
                Console.WriteLine("Equality button");
            }

            if (systemEntry == true)
            {
                Console.WriteLine("User Settings Button");
            }
            else
            {
                Console.WriteLine("Register Button");
            }

            Console.WriteLine(categoryTag);
        }
    }
}