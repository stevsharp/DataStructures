

namespace DataStructures;

internal class Runner
{
    /// <summary>
    /// Find max 
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public static int Max(int[] arr, int length)
    {

        for (int i = 0; i < arr.Length - 1 ; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                var temp = arr[i];

                arr[i] = arr[i + 1];

                arr[i + 1] = temp;
            }
        }

        var map = arr[length - 1];

        return map;
    }

    public static void BubbleSort(int[] arr, int length)
    {

        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }

            }
        }

        for (int i = 0; i < length - 1; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

