namespace GenericsMaxMin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Maximum and Minimum\n");

            int result = FindMaximum.FindMax(72, 89, 38);
            Console.WriteLine("Max Integer is:" + result);
        }
    }
}