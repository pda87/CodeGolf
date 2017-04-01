using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/100613/convert-csv-to-table
  class ConvertCSVToTable
  {
    //Nice version, before Golfing...
    public string T(string[] c)
    {
      int width = c.Max(r => r.Length),
        longestFirstColumn = c.Select(r => r.Split(',')[0].Length).Max(),
        longestSecondColumn = c.Select(r => r.Split(',')[1].Length).Max(),
        longestThirdColumn = c.Select(r => r.Split(',')[2].Length).Max();

      string o = "", lr = "\r\n", border = "",
        firstColumnFiller = string.Concat(Enumerable.Repeat("─", longestFirstColumn)),
        secondColumnFiller = string.Concat(Enumerable.Repeat("─", longestSecondColumn)),
        thirdColumnFiller = string.Concat(Enumerable.Repeat("─", longestThirdColumn));

      Func<string, int, string> padRight = (a, b) => { return a.PadRight(b); };

      border = "┌" + firstColumnFiller
        + "┬" +
        secondColumnFiller + "┬"
        + thirdColumnFiller
        + "┐";

      o += border + lr;

      var firstRow = c.First().Split(',');

      o += "|" + padRight(firstRow[0], longestFirstColumn) +
        "|" + padRight(firstRow[1], longestSecondColumn) +
        "|" + padRight(firstRow[2], longestThirdColumn) + "|";

      border = "├" +
        firstColumnFiller + "┼" +
        secondColumnFiller + "┼" +
        thirdColumnFiller
        + "┤";

      o += lr + border + lr;

      for (int i = 1; i < c.Length; i++)
      {
        var row = c[i].Split(',');

        o += "|" + padRight(row[0], longestFirstColumn) + "|"
        + padRight(row[1], longestSecondColumn) + "|" +
        padRight(row[2], longestThirdColumn) + "|" + lr;
      }

      border = "└" +
        firstColumnFiller + "┴" +
        secondColumnFiller + "┴" +
        thirdColumnFiller
        + "┘";

      o += border;

      return o;
    }

    public string S(string[]f){int w=f.Max(r=>r.Length),a=f.Select(r=>r.Split(',')[0].Length).Max(),b=f.Select(r=>r.Split(',')[1].Length).Max(),c=f.Select(r=>r.Split(',')[2].Length).Max();string o="",n="\r\n",d="",j=string.Concat(Enumerable.Repeat("─",a)),k=string.Concat(Enumerable.Repeat("─",b)),l=string.Concat(Enumerable.Repeat("─",c));Func<string,int,string>z=(q,p)=>{return q.PadRight(p);};d="┌"+j+"┬"+k+"┬"+l+"┐";o+=d+n;var g=f.First().Split(',');o+="|"+z(g[0],a)+"|"+z(g[1],b)+"|"+z(g[2],c)+"|";d="├"+j+"┼"+k+"┼"+l+"┤";o+=n+d+n;for(int i=1;i<f.Length;i++){var h=f[i].Split(',');o+="|"+z(h[0],a)+"|"+z(h[1],b)+"|"+z(h[2],c)+"|"+n;}d="└"+j+"┴"+k+"┴"+l+"┘";o+=d;return o;}
  }
}