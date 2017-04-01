using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //God no... 
  //https://codegolf.stackexchange.com/questions/98389/square-unspiral-the-string
  class SquareUnspiralTheString
  {
    public string S(string s)
    {
      var array = new string[s.Length];
      int i = 0;
      while (i < s.Length)
      {
        array[i] = s.Substring(i, s.Length - i) + string.Join("", s.ToList().GetRange(0, i));
        i++;
      }

      string target = "abcdeabcdcbaedcbcdeabaede";

      var output =
        //First row -> abcde
        array.FirstOrDefault();
      //Vertical line down -> eabcd
      //abcdeabcd
      if (s.Length > 1)
      {
        output += string.Join("", array.ToList().Skip(1).Select(o => o.Last()))
        //Last row reversed -> dcbae
        //abcdeabcdcbae
        + string.Join("", array.Last().Reverse().Skip(1))
        //First column up -> edcba
        //abcdeabcdcbaedcb
        + string.Join("", array.ToList().Select(o => o.First()).Reverse().Skip(1).Take(s.Length - 2))
        //Across first row, skipping first and last -> cde
        //abcdeabcdcbaedcbcde
        + string.Join("", array[1].Skip(1).Take(s.Length - 2))
        //Down 2 -> ab
        //abcdeabcdcbaedcbcdeabaede
        //abcdeabcdcbaedcbcdeab
        + array[1].Substring(s.Length - 1, 1) + array[2].Substring(s.Length - 1, 1)
        //Left 1 -> a
        + "";



      }


      return "";
    }
  }
}
