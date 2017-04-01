using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/96973/shuffle-up-and-deal
  class ShuffleUpAndDeal
  {
    public string D()
    {
      var d = new string[15];

      for (int i = 2; i < 15; i++)
      {
        var a = i > 10 ? new Dictionary<int, string>() {
        { 11, "J" },
        { 12, "Q" },
        { 13, "K" },
        { 14, "A" },
        }[i] 
          : i+"";

        var r = "|          |";

        d[i] = string.Join("\n", new string[] {
          " __________",
          @"/          \",
          a.Length > 1 ? "| " + a + "       |" : "| " + a + "        |",
          r,
          r,
          r,
          r,
          r,
          a.Length > 1 ? "|       " + a +" |" : "|        " + a +" |",
          @"\__________/"});
      }

      return string.Join("\n", d);
    }

    public string E(){var d=new string[15];for(int i=2;i<15;i++){var a=i>10?new Dictionary<int,string>(){{ 11,"J"},{12,"Q"},{13,"K"},{14,"A"},}[i]:i+"";var r="|          |";d[i]=string.Join("\n",new string[]{" __________",@"/          \",a.Length>1?"| "+a+"       |":"| "+a+"        |",r,r,r,r,r,a.Length>1?"|       " + a +" |" : "|        "+a+" |",@"\__________/"});}return string.Join("\n",d);}
  }
}