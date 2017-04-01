using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/96923/find-the-maximum-deviation
  class MaximumDeviation
  {
    public int f(List<int> v, int d)
    {
      var l = new List<List<int>>();

      for (int i = 0; i < v.Count; i++)
      {
        if (v.Count - i >= d)
          l.Add(v.GetRange(i, d));
      }

      return l.Select(o => o.Max() - o.Min()).Max();
    }

    public int i(List<int> v,int d){var l=new List<List<int>>();for(int i=0;i<v.Count;i++){if(v.Count-i>=d)l.Add(v.GetRange(i,d));}return l.Select(o=>o.Max()-o.Min()).Max();}

    public IEnumerable<int> h(List<int> v, int d)
    {
      var lists = new List<List<int>>();

      for (int i = 0; i < v.Count; i++)
      {
        if (v.Count - i >= d)
          lists.Add(v.GetRange(i, d));

        yield return lists.Select(o => o.Max() - o.Min()).Max();
      }
    }

    public int g(List<int> v, int d)
    {
      var maxDev = 0;

      for (int i = 0; i < v.Count; i++)
      {
        if (v.Count - i >= d)
        {
          var a = v.GetRange(i, d);
          var b = a.Max() - a.Min();
          if (b > maxDev)
            maxDev = b;
        }
      }

      return maxDev;
    }
  }
}
