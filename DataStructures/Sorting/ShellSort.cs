namespace DataStructures.Sorting
{
    internal class ShellSort
    {
        public void Sort(int[] arr, int n)
        {
            int gap = n / 2;

            while (gap > 0)
            {
                int i = gap;

                while (i < n)
                {
                    int temp = arr[i];

                    int j = i - gap;

                    while (j >= 0 && arr[j] > temp) 
                    {
                        arr[j + gap] = arr[j];
                        j = j-  gap;
                    }


                    arr[j+gap] = temp;
                    i= i + 1;
                }

                gap = gap / 2;
            }
        }

        public void Test()
        {
            Console.WriteLine(" ShellSort Original Array ");

            var arr = new int[] { 1000, 150, 210, 47, 84, 95 };

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ShellSort Sorted");

            this.Sort(arr, arr.Length);

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
