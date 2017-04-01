using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //https://codegolf.stackexchange.com/questions/98513/print-a-letter-fibonacci
  class FibonacciLetter
  {
    public string L(int n)
    {
      var r = new List<string>() { "a", "b" };

      int i = 3;

      while (i <= n)
      {
        r.Add(string.Concat(r[i-3], r[i-2]));
        i++;
      }

      return string.Join("\r\n", r);
    }

    public string M(int n){var r=new List<string>(){"a","b"};int i=3;while(i<=n){r.Add(string.Concat(r[i-3],r[i-2]));i++;}return string.Join("\r\n", r);}

  }
}