using System;

namespace Sorting
{
  public class MergeSortIterative : IIntegerSortAlgorithm
  {
    public int[] _input { get; set; }

    public MergeSortIterative(int[] input)
    {
      _input = input;
    }

    public int[] Sort()
    {
      return MergeSort(_input, _input.Length);
    }

    private int[] MergeSort(int[] input, int inputLength)
    {
      for (int currSize = 1; currSize <= inputLength - 1; currSize = currSize * 2)
      {
        for (int leftStart = 0; leftStart < inputLength - 1; leftStart += currSize * 2)
        {
          int mid = leftStart + currSize - 1;
          int rightEnd = Math.Min(inputLength - 1, (leftStart + 2 * currSize) - 1);

          _input = Merge(input, leftStart, mid, rightEnd);
        }
      }

      return _input;
    }

    public int[] Merge(int[] input, int start, int mid, int end)
    {
      int p = start, q = mid + 1;

      int[] temp = new int[end - start + 1];
      int k = 0;

      for (int i = start; i <= end; i++)
      {
        if (p > mid)
          temp[k++] = input[q++];
        else if (q > end)
          temp[k++] = input[p++];
        else if (input[p] < input[q])
          temp[k++] = input[p++];
        else if (input[q] < input[p])
          temp[k++] = input[q++];
      }

      for (int x = 0; x < k; x++)
      {
        input[start++] = temp[x];
      }
      return input;
    }
  }
}
