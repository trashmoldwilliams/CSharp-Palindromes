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

    public bool GetResults()
    {
      char[] inputArray = _input.ToLower().ToCharArray();
      char[] charArrayReversed = inputArray;
      Array.Reverse(charArrayReversed);
      string results = string.Join("", charArrayReversed);

      if(_input == results)
      {
        return true;
      }
      else
      {
        return false;
      }

    }

  }
}


//   if (_input.Length % 2 == 0)
//   {
//     int sliceVal = _input.Length / 2;
//     string front = _input.Substring(0, (sliceVal - 1));
//     string back = _input.Substring((sliceVal + 1), (_input.Length - 1));
//     char[] frontArray = front.ToCharArray();
//     char[] backArray = back.ToCharArray();
//     Array.Reverse(backArray);
//     int matchCount = 0;
//
//     for (var i = 0; i <= frontArray.Length; i++)
//     {
//       if (frontArray == backArray)
//       {
//         matchCount += 1;
//       }
//     }
//
//     if (matchCount == 1)
//     {
//       return true;
//
//     } else
//     {
//       return false;
//     }
//   } else
//   {
//     return false;
//   }
// }
