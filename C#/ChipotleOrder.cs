using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/90738/can-i-take-your-order-a-chipotle-concept-conund
  class ChipotleOrder
  {
    public string O(string s)
    {
      var c = new List<string>();

      var m = new Dictionary<int, List<string>>()
      {
        {0, new List<string>(){"burrito", "burrito bowl"}},
        {1, new List<string>(){"", "black beans", "pinto beans"}},
        {2, new List<string>(){ "", "white rice", "brown rice"}},
        {3, new List<string>(){ "", "chicken", "sofritas", "steak"}},
        {4, new List<string>(){ "", "mild salsa", "medium salsa", "hot salsa"}},
        {5, new List<string>(){"corn"}},
        {6, new List<string>(){"guacamole"}},
        {7, new List<string>(){"sour cream"}},
        {8, new List<string>(){"cheese"}},
      };

      for (int i = 0; i < s.Length; i++)
      {
        if (i == 0)
        {
          c.Add(s[0] == 'A' ? m[0][0] : m[0][1] + " with:");
          continue;
        }

        if (i > 4)
        {
          c.Add(s[i] == 'Y' ? m[i][0] : "");
          continue;
        }

        c.Add(m[i][int.Parse(s[i] + "")]);
      }

      return string.Join("\n", c.Where(o => !string.IsNullOrEmpty(o)));
    }
  }
}