using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
  public class MergeSortList : IIntegerSortAlgorithm
  {
    public int[] _input { get; set; }

    public MergeSortList(int[] input)
    {
      _input = input;
    }

    public int[] Sort()
    {

      _input = SortList(_input).ToArray();

      return _input;
    }

    public int[] SortList(int[] input)
    {
      if (input.Length <= 1) return input;

      var left = new List<int>();
      var right = new List<int>();

      Divide(input, left, right);

      left = SortList(left.ToArray()).ToList();
      right = SortList(right.ToArray()).ToList();

      return Merge(left, right);
    }

    public void Divide(int[] input, List<int> left, List<int> right)
    {
      for (int i = 0; i < input.Length; i++)
      {
        if (i % 2 > 0)
          left.Add(input[i]);
        else
          right.Add(input[i]);
      }
    }

    public bool NotEmpty(List<int> input)
    {
      return input.Count > 0;
    }

    public int[] Merge(List<int> left, List<int> right)
    {
      var result = new List<int>();

      while (NotEmpty(left) && NotEmpty(right))
      {
        MoveValueFromSourceToResult(left.First() <= right.First() ? left : right, result);
      }

      while (NotEmpty(left))
      {
        MoveValueFromSourceToResult(left, result);
      }

      while (NotEmpty(right))
      {
        MoveValueFromSourceToResult(right, result);
      }

      return result.ToArray();
    }

    private void MoveValueFromSourceToResult(List<int> input, List<int> result)
    {
      result.Add(input.First());
      input.RemoveAt(0);
    }
  }
}
