namespace Sorting
{
  public sealed class SortClas
  {
    private int[] _input;
    public SortClas(int[] input)
    {
      _input = input;
    }
    public int[] Sort()
    {
      for (int i = 0; i < _input.Length; i++)
      {
        int maxIndex = 0;
        for (int j = 0; j < _input.Length - i; j++)
        {
          if (_input[j] > _input[maxIndex])
            maxIndex = j;
        }

        var temp = _input[_input.Length - 1 - i];
        _input[_input.Length - 1 - i] = _input[maxIndex];
        _input[maxIndex] = temp;
      }
      return _input;
    }
  }
}
