namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a list without collections
            MyList<string> names = new MyList<string>();

            names.Add("Engin");
        }
    }
}