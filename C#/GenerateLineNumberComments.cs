using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  class GenerateLineNumberComments
  {
    private void A()
    {

    }

    public void C(string s)
    {
      var a = s.Split(new string[] { ";", "{", "}"}, StringSplitOptions.None);
      int n = 1;
      foreach (var l in a)
      {
        Console.WriteLine("/*" + n + "*/" + l);
        n++;
      }
    }
  }
}