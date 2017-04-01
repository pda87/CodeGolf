using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/94695/unlucky-numbers
  class UnluckyNumbers
  {
    public string U(int p1, int p2)
    {
      var intDictionary = new Dictionary<int, int>();

      int i = 1;

      while (intDictionary.Keys.Count < 500)
      {
        intDictionary.Add(i, i);
        i++;
      }

      var u1List = intDictionary.Where(o => o.Key % 2 == 0).ToList();
      var u2List = intDictionary.Where(o => o.Key % 3 == 0).ToList();
      
      var u3List = new List<int>();
      var u4List = new List<int>();

      //int index = 1;

      //var u1List = new List<int>();
      //var u2List = new List<int>();
      //var u3List = new List<int>();
      //var u4List = new List<int>();

      //int n = 2;

      //while (true)
      //{
        

      //  if (index > intList.Count)
      //  {
      //    break;
      //  }

      //  u1List.Add(intList[index]);
      //  index += n;

      //  u2List.Add(intList[index]);
      //  index += n + 1;
      //}

      return "";
    }
  }
}