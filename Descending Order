using System;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    // Bust a move right here
    var digits = Math.Abs(num).ToString().ToCharArray();
    Array.Sort(digits);
    bool neg = (num<0);
    if (!neg) {
      Array.Reverse(digits);
    }
    return int.Parse(new string(digits))*(neg ? -1 :1);
  }
}
