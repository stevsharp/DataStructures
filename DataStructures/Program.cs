using DataStructures;
using DataStructures.Sorting;
using DataStructures.Stack;

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

    InsertionSort insertionSort = new InsertionSort();
    insertionSort.Test();

    ShellSort shellSort = new ShellSort();
    shellSort.Test();

    Console.WriteLine("**********************************************");
    MergeSort mergeSort = new MergeSort();
    mergeSort.Test();

    Console.WriteLine("**********************************************");
    StacksArray stacksArray = new StacksArray(10);
    stacksArray.Test(); 



}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();