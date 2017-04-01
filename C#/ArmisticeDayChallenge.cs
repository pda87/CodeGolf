using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //https://codegolf.stackexchange.com/questions/99454/armistice-day-challenge
  class ArmisticeDayChallenge
  {
   public string A(int n)
    {
      string a = "", b = "||  ||";
      for (int i = 0; i < n; i++)
        a += b + "  //  ".PadLeft(5 + n - i, '\0') + string.Concat(Enumerable.Repeat(" ", i)) + b + "\n";
      return a;
    }

    public string N(int n){string a="",b= "||  ||";for(int i=0;i<n;i++)a+=b+"  //  ".PadLeft(5+n-i,'\0')+string.Concat(Enumerable.Repeat(" ",i))+b+"\n";return a;
    }
  }
}