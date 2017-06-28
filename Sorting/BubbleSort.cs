namespace Sorting
{
  public class BubbleSort : IIntegerSortAlgorithm
  {
    public int[] _input { get; }

    public BubbleSort(int[] input)
    {
      _input = input;
    }

    public int[] Sort()
    {
      for (int i = _input.Length - 1; i >= 0; i--)
      {
        for (int j = 0; j < i; j++)
        {
          if (_input[j] > _input[j + 1])
          {
            int temp = _input[j];
            _input[j] = _input[j + 1];
            _input[j + 1] = temp;
          }
        }
      }

      return _input;
    }
  }
}
