namespace Sorting
{
  class InsertionSort : IIntegerSortAlgorithm
  {
    public int[] _input { get; set; }

    public InsertionSort(int[] input)
    {
      _input = input;
    }

    public int[] Sort()
    {
      for (int i = 1; i < _input.Length; i++)
      {
        int index = _input[i];
        int j = i;

        while (j > 0 && _input[j - 1] > index)
        {
          var temp = _input[j];
          _input[j] = _input[j - 1];
          _input[j - 1] = temp;
          j--;
        }
      }
      return _input;
    }
  }
}
