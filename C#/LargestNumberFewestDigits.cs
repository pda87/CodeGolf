using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/93399/output-the-largest-number-with-the-fewest-digits
  class LargestNumberFewestDigits
  {
    public void F(List<int> n){var g=n.GroupBy(o=>(o+"").Length);Console.Write(g.Where(o=>o.Key==g.Min(k=>k.Key)).OrderBy(o=>o).First().Max());}
    
    public int L(int[]n)
    {
      var g = n.GroupBy(o => (o + "").Length);
      return g.Where(o => o.Key == g.Min(k => k.Key)).OrderBy(o => o).First().Max();
    }
  }
}
