namespace DataStructures.Sorting;

internal class SelectionSort
    {
        public void selectionSort(int[] arr , int n) 
        {
            for (int i = 0; i < n - 1; i++)
            {
                int position = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[position])
                    {
                        position = j;

                    }

                    int temp = arr[i];
                    arr[i] = arr[position];
                    arr[position] = temp;   

                }   
            }

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

        }

        public void Test()
        {
            Console.WriteLine("Original Array ");

            var arr = new int[] { 1000, 150, 210, 47, 84, 95 };

            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Selection Sorted");

            this.selectionSort(arr, arr.Length);
        }
           
    }

