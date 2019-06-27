using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    //bool result = 0;
    int xcount = 0;
    int ocount = 0;
    string Input = input.ToLower();
    for (int i=0; i<Input.Length; i++)
    {
      if (Input[i] == 'x') {xcount++;}
      else if (Input[i] == 'o') {ocount++;}
    }
    return (xcount == ocount) ? true : false;
  }
}
