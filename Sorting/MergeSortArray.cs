namespace Sorting
{
  public class MergeSortArray : IIntegerSortAlgorithm
  {
    public int[] _input { get; set; }

    public MergeSortArray(int[] input)
    {
      _input = input;
    }
    public int[] Sort()
    {
      return MergeSort(_input, 0, _input.Length - 1);
    }

    public int[] MergeSort(int[] input, int start, int end)
    {

      if (start < end)
      {
        int mid = (start + end) / 2;
        MergeSort(input, start, mid);
        MergeSort(input, mid + 1, end);

        input = Merge(input, start, mid, end);
      }

      return input;
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
