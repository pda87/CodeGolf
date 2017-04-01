using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/92168/slowly-turn-a-string-into-another
  class SlowlyTurnAString
  {
    public void f(string a, string b)
    {
      int i = a.Length;

      while (i > 0)
      {
        Console.WriteLine(a.Substring(0, i));
        i--;
      }

      i = 2;

      while (i <= b.Length)
      {
        Console.WriteLine(b.Substring(0, i));
        i++;
      }
    }
  }
}