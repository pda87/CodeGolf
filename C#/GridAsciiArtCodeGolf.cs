using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/101469/grid-ascii-art-code-golf
  class GridAsciiArtCodeGolf
  {
    public string G(int c, int r, char a)
    {
      if (c < 1 || c > 5 || r < 1 || r > 5) return "Index Error";
      var b = "00000";
      var d = new string[] { b, b, b, b, b };
      d[r - 1] = d[r - 1].Substring(0, c - 1) + a + d[r - 1].Substring(c);
      return string.Join("\r\n", d.Reverse());
    }

    public string H(int c,int r,char a){if(c<1||c>5||r<1||r>5)return"Index Error";var b="00000";var d=new string[]{b,b,b,b,b};d[r-1]=d[r-1].Substring(0,c-1)+a+d[r-1].Substring(c);return string.Join("\r\n",d.Reverse());}
  }
}