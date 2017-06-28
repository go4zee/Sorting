using System.Collections.Generic;

namespace Sorting
{
  public class BucketSort : IIntegerSortAlgorithm
  {
    private const int DefaultBucketSize = 5;
    public int[] _input { get; }

    public BucketSort(int[] input)
    {
      _input = input;
    }

    public int[] Sort()
    {
      if (_input.Length == 0) return _input;

      int minValue = _input[0];
      int maxValue = _input[0];
      for (int i = 1; i < _input.Length; i++)
      {
        if (_input[i] < minValue)
          minValue = _input[i];
        if (_input[i] > maxValue)
          maxValue = _input[i];
      }

      int bucketCount = (maxValue - minValue) / DefaultBucketSize + 1;

      IList<List<int>> buckets = new List<List<int>>(bucketCount);
      for (int i = 0; i < bucketCount; i++)
      {
        buckets.Add(new List<int>());
      }

      for (int i = 0; i < _input.Length; i++)
      {
        buckets[(_input[i] - minValue) / DefaultBucketSize].Add(_input[i]);
      }

      int currentIndex = 0;
      for (int i = 0; i < buckets.Count; i++)
      {
        var bucketsArray = buckets[i].ToArray();
        var sorted = new InsertionSort(bucketsArray).Sort();
        for (int j = 0; j < sorted.Length; j++)
        {
          _input[currentIndex++] = sorted[j];
        }
      }
      return _input;
    }
  }
}
