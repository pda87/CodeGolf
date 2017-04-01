using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/97018/print-the-tetration
  class PrintTheTitration
  {
    public string T(int a, int b)
    {
      double d = a;

      for (int i = 1; i <= b; i++)
      {
        d = Math.Pow(d, a);
      }

      return d.ToString();
    }
  }
}
