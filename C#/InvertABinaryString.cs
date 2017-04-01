using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/30361/the-shortest-code-to-invert-a-binary-string
  class InvertABinaryString
  {
    public string f(string s)
    {
      string a = string.Empty;
      string b = string.Empty;

      s.ToList().ForEach(o => a += int.Parse(!Convert.ToBoolean(int.Parse(o.ToString()))+""));
      //s.ToList().ForEach(o => Convert.ToBoolean(int.Parse(o+"")));

      //a.ToList().ForEach(o => b += int.Parse(o.ToString()));

      return a;
    }
  }
}