using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};
        string sentence = str.ToLower();
        for (int i = 0; i<sentence.Length; i++){
          if (vowels.Contains(sentence[i])){
            vowelCount++;
            }
        }

        return vowelCount;
    }
}
