using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //Gap should be 3 after 12 lines
  //  string a = "                                               ";
  //https://codegolf.stackexchange.com/questions/97651/alphabet-wings
  class AlphabetWings
  {
    public string A()
    {
      string a = "abcdefghijklmnopqrstuvwxyz", r = string.Concat(a.Reverse()), o = "",x="",y="",z="";
      int i=0;
      var l = new List<string>();
      for (i = 0; i < 13; i++)
      {
        x = a.Substring(0, i);
        y = r.Substring(0, i);
        z = x + string.Concat(y.Reverse()) + 
          string.Concat(Enumerable.Repeat(" ", 51-i*4)) + 
          y + string.Concat(x.Reverse()) + "\n";
        o += z;
        l.Add(z.Replace(" ", "").Replace("zz", "z"));
      }
      o += a + r.Substring(1, r.Length - 1) + "\n";
      l.Reverse();
      for (i = 0; i < 12; i++)
        o += string.Concat(Enumerable.Repeat(" ", i + i + 2)) + l[i];
      return o;
    }


    public string B(){string a="abcdefghijklmnopqrstuvwxyz",r=string.Concat(a.Reverse()),o="",x="",y="",z="";int i=0;var l=new List<string>();for(i=0;i<13;i++){x=a.Substring(0,i);y=r.Substring(0,i);z=x+string.Concat(y.Reverse())+string.Concat(Enumerable.Repeat(" ",51-i*4))+y+string.Concat(x.Reverse())+"\n";o+=z;l.Add(z.Replace(" ","").Replace("zz","z"));}o+=a+r.Substring(1,r.Length-1)+"\n";l.Reverse();for(i=0;i<12;i++)o+=string.Concat(Enumerable.Repeat(" ",i+i+2))+l[i];return o;}
  }
}