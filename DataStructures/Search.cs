

namespace DataStructures;

internal class BinarySearch
{
    public int binarySearch(int[] arr, int n, int key)
    {
        var l = 0;         // left
        var r = n - 1;     // Right

        while (l <= r)
        {
            var mid = (l + r) / 2; // find mid of the array

            Console.Write($"Mid is : {mid}" + Environment.NewLine);

            if (key == arr[mid])
            {
                return mid;
            }
            else if (key > arr[mid])
            {
                l = mid + 1; // Adjust left boundary

                Console.Write($"Left is : {l}" + Environment.NewLine);
            }
            else if (key < arr[mid])
            {
                r = mid - 1; // Adjust right boundary

                Console.Write($"Right is : {l}" + Environment.NewLine);
            }
        }

        return -1;

    }

    public int binarySearchRecursion(int[] arr, int key, int l, int r)
    {
        if (l > r)
            return -1;

        var mid = (l + r) / 2; // find mid of the array

        if (key == arr[mid])
            return mid;
        else if (key < arr[mid])
            return binarySearchRecursion(arr, key, l, mid - 1);
        else if (key > arr[mid])
            return binarySearchRecursion(arr, key, mid + 1, r);


        return -1;

    }

    public void Test()
    {
        var arr = new int[] { 15, 21, 47, 84, 95 };

        var key = this.binarySearch(arr, arr.Length, 21);

        var keyRecursion = this.binarySearchRecursion(arr, 21, 0, 4);

        Console.WriteLine($"Key index is {key}");

        Console.WriteLine($"Key binary Search Recursion index is {keyRecursion}");
    }

}

