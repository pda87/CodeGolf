using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/93005/is-it-a-bumpy-word
  class BumpyWord
  {
    public bool Check(string word)
    {
      var chars = word.ToCharArray().ToList();
      chars.ForEach(o => Convert.ToByte(o));


      var evens = new List<int>();
      var odds = new List<int>();

      for (int i = 0; i < chars.Count; i++)
      {
        if (chars[i] % 2 == 0)
        {
          evens.Add(chars[i]);
        }
        else
        {
          odds.Add(chars[i]);
        }
      }

      return (string.Join("", evens.OrderBy(o => o.ToString()).ToList()) == string.Join("", evens) && string.Join("", odds.OrderByDescending(o => o.ToString()).ToList()) == string.Join("", odds))
        || (string.Join("", evens.OrderByDescending(o => o.ToString()).ToList()) == string.Join("", evens) && string.Join("", odds.OrderBy(o => o.ToString()).ToList()) == string.Join("", odds));

      //return false;
      //return string.Join("", chars.OrderBy(o => o.ToString()).ToList()) == word;
    }

  }
}
