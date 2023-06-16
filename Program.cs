namespace GenericsMaxString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics!\n");

            // -- Maximum Integer using CompareTo

            int result = FindMaximum.FindMax(87, 32, 66);
            Console.WriteLine("Max Integer is: " + result);

            // -- Maximum Float using CompareTo

            float result1 = FindMaximum.FindMaxFloat(32.4f, 56.8f, 18.7F);
            Console.WriteLine("Max Float is: " + result1);

            // -- Maximum String using CompareTo

            string result2 = FindMaximum.FindMaxString("Nikhil", "Gaurav", "Nakul");
            Console.WriteLine("Max string is: " + result2);
        }
    }
}
