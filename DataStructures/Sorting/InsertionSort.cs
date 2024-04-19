

namespace DataStructures.Sorting;

    internal class InsertionSort
    {
        public void Sort(int[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                var temp = arr[i];
                var position = i;

                while (position > 0 && arr[position - 1] > temp)
                {
                    arr[position] = arr[position - 1];
                    position--;
                }
                // do the swap
                arr[position] = temp;   
            }
       }

        public void Test()
        {
            Console.WriteLine(" InsertionSort Original Array ");

            var arr = new int[] { 1000, 150, 210, 47, 84, 95 };

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("InsertionSort Sorted");

            this.Sort(arr, arr.Length);

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
}

