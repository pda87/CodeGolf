using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/99094/alternating-fibonacci
  class AlternatingFibonacci
  {
    public int A(int n)
    {
      var f = new List<int> { 0, 1, 1 };

      for (int i = 3; i <= n; i++)
      {
        f.Add(i % 2 > 0 ? f[i - 1] + f[i - 2] : f[i - 2] - f[i - 1]);
      }

      return f[n];
    }

    public int B(int n){var f=new List<int>{0,1,1};for(int i=3;i<=n;i++){f.Add(i%2>0?f[i-1]+f[i-2]:f[i-2]-f[i-1]);}return f[n];}
  }
}