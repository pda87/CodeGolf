using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/101042/how-to-draw-melting-icicles
  class HowToDrawMeltingIcicles
  {
    public string I(int s, int m)
    {
      var o = "";
      int p = 1;

      for (int i = s+1; i > m; i -= 2)
      {
        var a = string.Concat(Enumerable.Repeat("v", i));
        if (i < s)
        {
          o += a.PadLeft(p + a.Length) + "\r\n";
          p++;
        }
        else
        {
          o += a + "\r\n";
        }
      }

      return o;
    }
  }
}