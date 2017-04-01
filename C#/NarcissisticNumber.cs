using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/15244/test-a-number-for-narcissism
  class NarcissisticNumber
  {
    public bool N(int n)
    {
      double a = 0;

      foreach (var digit in n.ToString())
      {
        a += Math.Pow(int.Parse(digit + ""), n.ToString().Length);
      }

      return a == n;
    }

    public bool F(int n){double a=0;foreach(var d in n+""){a+=Math.Pow(int.Parse(d+""),n+"".Length);}return a==n;}

  }
}