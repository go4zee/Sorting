using System;

namespace Sorting
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] input = { 9, 78, 5, 7, 3, 5, 19, 8, 19 };
      int[] input2 = { 29, 20, 73, 64, 34 };

      //      var insertionSorted = new InsertionSort(input2).Sort();
      //      var bucketSorted = new BucketSort(input2).Sort();
      //      var bubbleSorted = new BubbleSort(input2).Sort();
      //      var selectionSorted = new SelectionSort(input2).Sort();
      //      var bubbleSorted2 = BubbleSort(input2);
      //      var insertionSorted2 = InsertSort(input2);
      //      var selectionSorted2 = SelectionSort(input2);
      //      var mergeSortedList = new MergeSortList2(input2).Sort();
      //      var mergeSorted = new MergeSortArray(input2).Sort();
      //      var mergeSortedIterative = new MergeSortIterative(input2).Sort();
      var quickSort = new QuickSort(input2).Sort();

      var sorted = quickSort;
      foreach (var i in sorted)
      {
        Console.WriteLine(i);
      }
      Console.ReadKey();
    }

  }
}