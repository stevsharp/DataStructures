namespace DataStructures
{
    internal class BubbleSort
    {
        public void Sort(int[] arr, int n) 
        { 
            for (int i = n - 1; i >=0; i--)
            {
                for (int p = 0; p < i; p++)
                {
                    var numberOne = arr[p];
                    var numberTwo = arr[p + 1];

                    if (numberOne > numberTwo)
                    {
                        int temp = numberOne;

                        arr[p] = numberTwo;

                        arr[p + 1] = temp;
                    }
                }
            }
        }

        public void Test()
        {
            Console.WriteLine(" BubbleSort Original Array ");

            var arr = new int[] { 1000, 150, 210, 47, 84, 95 };

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("BubbleSort Sorted");

            this.Sort(arr, arr.Length);

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }


    }
}
