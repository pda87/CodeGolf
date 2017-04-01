using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //https://codegolf.stackexchange.com/questions/100060/goodness-giza-golf
  class GizaNumber
  {
    public bool G(string s)
    {
      int l = s.Count(), m = l/2;
      Func<int, int> p = x => int.Parse(s[x] +"");

      if (l % 2 == 0)
        return false;

      for (int i = 0; i < m; i++)
        if (p(i) + 1 != p(i+1))
          return false;

      return int.Parse(s.Max() + "") == p(m)
      &&
      s.Substring(0, m + 1) == string.Join("", s.Substring(m, l - m).Reverse());
    }

    public bool H(string s){int l=s.Count(),m=l/2;Func<int,int>p=x=>int.Parse(s[x]+"");if(l%2==0)return false;for(int i=0;i<m;i++)if(p(i)+1!=p(i+1))return false;return int.Parse(s.Max()+"")==p(m)&&s.Substring(0,m+1)==string.Join("",s.Substring(m,l-m).Reverse());}
  }
}