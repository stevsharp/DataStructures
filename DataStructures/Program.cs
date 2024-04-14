using DataStructures;

try
{
    int[] arr = new int[]{ 50, 100, 4, 10 , 60 , 10 , 20 };

    var max = Runner.Max(arr, arr.Length);

    Runner.BubbleSort(arr, arr.Length);

    SumOfNumber sumOfNumber = new SumOfNumber();
    sumOfNumber.Test();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();