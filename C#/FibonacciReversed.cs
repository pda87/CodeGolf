using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/85567/fibonacci-reversed
  class FibonacciReversed
  {
    public int GetFibonacciIndex(int n)
    {
      if (n < 0)
      {
        return -1;
      }

      var fibonacciArray = new int[4];

      fibonacciArray[1] = 1;

      int i = 0;

      while (fibonacciArray[3] < n)
      {
        fibonacciArray[3] = fibonacciArray.ToList().GetRange(1, 2).Sum();

        fibonacciArray[1] = fibonacciArray[2];
        fibonacciArray[2] = fibonacciArray[3];

        i++;
      }

      return i;
    }

    public int F(int n)
    {
      var a = new int[4];

      a[1] = 1;

      int i = 0;

      while (a[3] < n)
      {
        a[3] = a.ToList().GetRange(1, 2).Sum();

        a[1] = a[2];
        a[2] = a[3];

        i++;
      }

      return i;
    }

    public int G(int n){var a=new int[4];a[1]=1;int i=0;while(a[3]<n){a[3]=a.ToList().GetRange(1,2).Sum();a[1]=a[2];a[2]=a[3];i++;}return i;}
  }
}