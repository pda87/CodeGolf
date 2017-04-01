using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  class ZeroPointOne
  {
    public int c(int t)
    {
      List<string> l = new List<string>();

      for (int i = 1; i <= t; i++)
      {
        string n = i+"";
        int z = 100 * i;

        n = (decimal.Parse(i+"")/10)+"";

        while (n.Length <= (i * 100) + 3)
        {
          n = n.Replace(".", ".0");
          l.Add(n);
        }
      }

      return l.Count;
    }

    public int d(int t){List<string> l=new List<string>();for(int i=1;i<=t;i++){string n=i+"";int z=100*i;n=(decimal.Parse(i+"")/10)+"";while(n.Length<=(i*100)+3){n=n.Replace(".",".0");l.Add(n);}}return l.Count;}
  }
}