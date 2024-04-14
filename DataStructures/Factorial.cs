
namespace DataStructures
{
    internal class Factorial
    {
        public int WithLoop(int n)
        {
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        public int WithRecursive(int n)
        {
            if (n == 0)
                return 1;


            return WithRecursive(n - 1) * n ;
        }

        public void Test()
        {

            Console.WriteLine($"Factorial:{WithLoop(5)}");

            Console.WriteLine($"Factorial:{WithRecursive(5)}");

        }
    }
}
