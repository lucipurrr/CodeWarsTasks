using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int Solution(int value)
  {
    List<int> numbers = new List<int>();
    for (int i = 3; i<value; i+=3){
    	numbers.Add(i);
    }
    for (int j = 5; j<value; j+=5){
    	numbers.Add(j);
    }
    return (numbers.Distinct()).Sum();
  }
}
