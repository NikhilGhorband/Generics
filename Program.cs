namespace GenericsMaxFloat
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Maximum Number\n");

            // -- Maximum Integers using CompareTo

            int result = FindMaximum.FindMax(87, 58, 66);
            Console.WriteLine("Max Integer is: " + result);

            // -- Maximum Float using CompareTo

            float result1 = FindMaximum.FindMaxFloat(22.8f, 32.4f, 18.5F);
            Console.WriteLine("Max Float is: " + result1);
        }
    }
}
