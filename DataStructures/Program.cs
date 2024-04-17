using DataStructures;
using DataStructures.Sorting;

try
{
    int[] arr = new int[]{ 50, 100, 4, 10 , 60 , 10 , 20 };

    var max = Runner.Max(arr, arr.Length);

    Runner.BubbleSort(arr, arr.Length);

    SumOfNumber sumOfNumber = new SumOfNumber();
    sumOfNumber.Test();

    Factorial factorial = new Factorial();
    factorial.Test();

    BinarySearch binarySearch = new BinarySearch();

    binarySearch.Test();

    SelectionSort selectionSort = new SelectionSort();

    selectionSort.Test();

    BubbleSort bubbleSort = new BubbleSort();
    bubbleSort.Test();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();