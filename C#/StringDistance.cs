using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/93596/string-distance
  class StringDistance
  {
    public int f(string k)
    {
      int t = 0;
      var a = k;
      Func<Char, int> x = (c) => int.Parse("" + Convert.ToByte(c)) - 97;
      for (int i = 0; i < a.Length - 1; i++)
      {
        var f = x(a[i]);
        var s = x(a[i + 1]);
        var d = Math.Abs(f - s);
        t += d > 13 ? 26 - Math.Max(f, s) + Math.Min(f, s) : d;
      }
      return t;
    }

    public IEnumerable<int> g(string k)
    {
      Func<Char, int> x = (c) => int.Parse("" + Convert.ToByte(c)) - 97;
      for (int i = 0; i < k.Length - 1; i++)
      {
        var f = x(k[i]);
        var s = x(k[i + 1]);
        var d = Math.Abs(f - s);
        yield return d > 13 ? 26 - Math.Max(f, s) + Math.Min(f, s) : d;
      }
    }
  }
}