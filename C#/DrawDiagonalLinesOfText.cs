using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //https://codegolf.stackexchange.com/questions/99685/draw-diagonal-lines-of-text
  class DrawDiagonalLinesOfText
  {
    public string D(string[] s)
    {
      int x = 0, y = 0, r = 0, q = 2 * (s.Max().Length + s.Length) + 1;
      var a = new char[q, q];
      for (int i = 0; i < s.Length; i++)
      {
        y = r;
        for (int j = 0; j < s[i].Length; j++)
        {
          a[y, x] = s[i][j];
          x += 1;
          y += 1;
        }
        x = 0;
        r +=3;
      }
      var o = "";
      for (x = 0; x < q; x++)
      {
        var t = "";
        for (y = 0; y < q; y++)
          t += a[x, y];
        o += t == string.Join("", Enumerable.Repeat('\0', q)) ? "" : (t.TrimEnd('\0') + "\r\n");
      }
      return o;
    }

    public string E(string[]s){int x=0,y=0,r=0,q=2*(s.Max().Length+s.Length)+1;var a=new char[q, q];for(int i=0;i<s.Length;i++){y=r;for(int j=0;j<s[i].Length;j++){a[y,x]=s[i][j];x+=1;y+=1;}x=0;r+=3;}var o="";for(x=0;x<q;x++){var t="";for(y=0;y<q;y++)t+=a[x,y];o+=t==string.Join("",Enumerable.Repeat('\0',q))?"":(t.TrimEnd('\0')+"\r\n");}return o;}


  }
}