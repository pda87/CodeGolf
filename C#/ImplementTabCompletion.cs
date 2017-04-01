using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/94210/implement-tab-completion
  class ImplementTabCompletion
  {
    public string T(string p1, List<string> p2)
    {
      var list = p2.FindAll(o => o.StartsWith(p1.Substring(0, 1)));

      if (list.Count == 0)
      {
        return p1;
      }

      if (list.Count == 1)
      {
        return list.First();
      }

      int subStringIndex = 1;

      var commonBit = list[0].Substring(0, subStringIndex);

      while (true)
      {
        if (list.All(o => o.Contains(commonBit)))
        {
          if (commonBit.Length == p1.Length)
          {
            break;
          }

          subStringIndex++;

          if (subStringIndex > p1.Length)
          {
            subStringIndex--;
            commonBit = list[0].Substring(0, subStringIndex);
            break;
          }

          commonBit = list[0].Substring(0, subStringIndex);
        }
        else
        {
          subStringIndex--;
          commonBit = list[0].Substring(0, subStringIndex);
          break;
        }
      }

      return commonBit;
    }
  }
}