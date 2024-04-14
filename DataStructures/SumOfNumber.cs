namespace DataStructures
{
    public class SumOfNumber
    {
        public int SumN(int n)
        {
            return n * (n + 1) / 2;
        }

        public int SumNIteration(int n)
        {
            int total = 0;
            int i = 1;

            while (i <= n)
            {
                total += i;
                i++;
            }

            return total;
        }


        public int SumNRecursion(int n)
        {
            if (n == 0)
                return 0;

            return SumNRecursion(n - 1) + n;
        }
            

        public void Test()
        {
            Console.WriteLine($"Sum:{SumN(5)}");
            Console.WriteLine($"Sum:{SumNIteration(5)}");
            Console.WriteLine($"Sum:{SumNRecursion(5)}");
        }
    }
}
