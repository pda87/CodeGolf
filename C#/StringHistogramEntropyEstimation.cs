using System;
using System.Linq;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/78507/compute-the-histogram-entropy-estimation-of-a-string
  class StringHistogramEntropyEstimation
  {
    public string f(string s)
    {
      var l = s.Length;
      double sum = 0;
      foreach (var item in s.GroupBy(o => o))
      {
        double p = (double)item.Count() / l;
        sum += p * Math.Log(p, 2);
      }
      return (sum *= -l) + "";
    }
  }
}
