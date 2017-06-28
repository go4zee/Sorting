namespace Sorting
{
  public class QuickSort : IIntegerSortAlgorithm
  {
    public int[] _input { get; }

    public QuickSort(int[] input)
    {
      _input = input;
    }

    public int[] Sort()
    {
      return QuickSortArray(_input, 0, _input.Length - 1);
    }

    private int[] QuickSortArray(int[] input, int start, int end)
    {
      int i = start, j = end;

      int pivot = input[start + (end - start) / 2];

      while (i <= j)
      {
        while (input[i] < pivot)
        {
          i++;
        }

        while (input[j] > pivot)
        {
          j--;
        }

        if (i <= j)
        {
          int temp = input[i];
          input[i] = input[j];
          input[j] = temp;

          i++;
          j--;
        }

        if (start < j)
          QuickSortArray(input, start, j);
        if (i < end)
          QuickSortArray(input, i, end);

      }

      return input;
    }
  }
}
