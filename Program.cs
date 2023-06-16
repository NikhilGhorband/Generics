namespace GenericsTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics!\n");

            GenericsMaximum<int> obj = new GenericsMaximum<int>(18 , 35, 45);

            int result = obj.FindMaxUsingGenerics(18 , 35, 85);

            Console.WriteLine(result);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Greatest number among three numbers is :" + result);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");

            GenericsMaximum<float> obj1 = new GenericsMaximum<float>(23.25f, 74.82f, 47.32f);

            float result2 = obj1.FindMaxUsingGenerics(6.28f, 40.37f, 47.25f);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("Greatest number among three numbers is :" + result2);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::");

        }
    }
}