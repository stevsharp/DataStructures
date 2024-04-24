

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


    public void AnotherSort(int[] arr, int n)
    {
        for (int firstUnsortedIndex = 1; firstUnsortedIndex < n; firstUnsortedIndex++)
        {
            int newElement = arr[firstUnsortedIndex];
            int j = 0;

            for (j = firstUnsortedIndex; j > 0 && arr[j - 1] > newElement; j--)
            {
                var numberOne = arr[j - 1];

                var numberTwo = arr[j];

                arr[j] = arr[j - 1];
            }

            arr[j] = newElement;
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

        //this.Sort(arr, arr.Length);
        this.AnotherSort(arr, arr.Length);

        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

