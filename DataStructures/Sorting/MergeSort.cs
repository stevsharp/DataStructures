namespace DataStructures.Sorting
{
    internal class MergeSort
    {
        public void Sort(int[] arr, int start, int end)
        {
            if (end - start <= 1)
            {
                return;
            }

            // find the mid of the array
            int mid = (start + end) / 2;
            this.Sort(arr, start, mid);
            this.Sort(arr, mid, end);
            Merge(arr, start, mid, end);
        }

        private void Merge(int[] arr, int start, int mid, int end)
        {
            if (arr[mid - 1] <= arr[mid])
                return;

            int i = start;
            int j = mid;
            int tempIndex = 0;

            int[] temp = new int[end - start];

            while (i < mid && j < end)
            {
                temp[tempIndex++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];
            }

            Array.Copy(arr, j, arr, start + tempIndex, end - j);
            Array.Copy(temp, 0, arr, start, tempIndex);
        }

        public void Test()
        {
            Console.WriteLine(" MergeSort Original Array ");

            var arr = new int[] { 1000, 150, 210, 47, 84, 95 };

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("MergeSort Sorted");

            this.Sort(arr, 0, arr.Length);

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
