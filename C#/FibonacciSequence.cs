using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/85/fibonacci-function-or-sequence
  class FibonacciSequence
  {
    public int FibonacciNumber(int number)
    {
      var fibonacciArray = new int[number + 1];

      fibonacciArray[0] = 0;
      fibonacciArray[1] = 1;

      for (int i = 2; i <= number; i++)
      {
        var previousTwoNumbers = fibonacciArray.ToList().GetRange(i - 2, 2);

        fibonacciArray[i] = previousTwoNumbers.Sum();
      }

      return fibonacciArray[number];
    }
  }
}