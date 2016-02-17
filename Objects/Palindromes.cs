using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace Palindromes.Objects
{
  public class PalindromeFinder
  {
    private string _input;

    public PalindromeFinder(string myInput)
    {
      _input = myInput;
    }

    public string GetResults()
    {
      int matchCount = 0;
      int i = 0;
      int j = _input.Length - 1;
      for (i = i; i < j; i++)
      {
        if (_input[i] == _input[j])
        {
          matchCount += 1;
          Console.WriteLine("MatchC: " + matchCount);
        }
        j -= 1;
      }

      int requirement = 0;

      if (_input.Length % 2 != 0)
      {
        requirement = (_input.Length - 1);
      } else
      {
        requirement = _input.Length;
      }

      if (matchCount == requirement / 2)
      {
        return "Yes";
      } else
      {
        return "No";
      }

    }
  }
}
