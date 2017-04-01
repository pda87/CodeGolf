using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //https://codegolf.stackexchange.com/questions/97456/draw-an-alphabet-party-hat
  class DrawAnAlphabetHat
  {
    public string Centered()
    {
      string o = "", a = "abcdefghijklmnopqrstuvwxyz";
      int p = 12, i = 0;
      for (i = 0; i <= 26; i++)
      {
        o += string.Concat(Enumerable.Repeat(" ", 20)) + a.Substring(26 - i, i).PadLeft(p + i) + "\n";
        if (i == 0 || i == 1) continue;
        p -= i % 2 == 0 ? 1 : 0;
      }
      return o;
    }

    public string H()
    {
      string o = "", a = "abcdefghijklmnopqrstuvwxyz";
      int p = 12, i=0;
      for (i = 0; i <= 26; i++)
      {
        o += a.Substring(26 - i, i).PadLeft(p+i)+ "\n";  
        if (i == 0 || i == 1) continue;
        p -= i % 2 == 0 ? 1 : 0;
      }
      return o;
    }

    public string I(){string o="",a="abcdefghijklmnopqrstuvwxyz";int p=12,i=0;for(i=0;i<=26;i++){o+=a.Substring(26-i,i).PadLeft(p+i)+"\n";if(i==0||i==1)continue;p-=i%2==0?1:0;}return o;}
  }
}