namespace Sorting
{
  public class SelectionSort : IIntegerSortAlgorithm
  {
    public int[] _input { get; }

    public SelectionSort(int[] input)
    {
      _input = input;
    }
    public int[] Sort()
    {
      for (int i = 0; i < _input.Length; i++)
      {
        int min = i;
        for (int j = i + 1; j < _input.Length; j++)
        {
          if (_input[j] < _input[min])
            min = j;
        }
        int temp = _input[i];
        _input[i] = _input[min];
        _input[min] = temp;
      }

      return _input;
    }
  }
}