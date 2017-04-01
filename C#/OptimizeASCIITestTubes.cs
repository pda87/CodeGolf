using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/102802/optimize-ascii-test-tubes
  class OptimizeASCIITestTubes
  {
    //First attempt, works but totally ungolfed:
    public string T(int n, int[] l)
    {
      var o = "";

      var totalWater = l.Sum();

      if (totalWater == 0)
        return "";

      var leftOverWater = totalWater % 8;

      var numberOfFullTubes = totalWater / 8;

      var numberOfPartiallyFullyTubes = leftOverWater > 0 ? 1 : 0;

      var heightList = new List<int>();

      for (int i = 0; i < numberOfFullTubes; i++)
        heightList.Add(8);

      heightList.Add(leftOverWater);

      var numberOfTubesRequired = numberOfFullTubes + numberOfPartiallyFullyTubes;

      var tubeArrays = new List<List<string>>();

      for (int i = 0; i < numberOfTubesRequired; i++)
      {
        tubeArrays.Add(new List<string>());

        var height = heightList[i];

        for (int j = 8; j > 0; j--)
        {
          tubeArrays[i].Add(j == height ? "|~~| " : "|  | ");
        }
      }

      for (int j = 0; j < 8; j++)
      {
        o += string.Concat(tubeArrays.Select(p => p[j])) + "\r\n";
      }

      o += string.Concat(Enumerable.Repeat("|__| ", numberOfTubesRequired));

      return o;
    }

    public string W(int n, int[] l)
    {
      var o = "";

      var totalWater = l.Sum();

      if (totalWater == 0)
        return "";

      var leftOverWater = totalWater % 8;

      var numberOfFullTubes = totalWater / 8;

      var numberOfPartiallyFullyTubes = leftOverWater > 0 ? 1 : 0;

      var heightList = new List<int>();

      for (int i = 0; i < numberOfFullTubes; i++)
        heightList.Add(8);

      heightList.Add(leftOverWater);

      var numberOfTubesRequired = numberOfFullTubes + numberOfPartiallyFullyTubes;

      var tubeArrays = new List<List<string>>();

      for (int i = 0; i < numberOfTubesRequired; i++)
      {
        tubeArrays.Add(new List<string>());

        var height = heightList[i];

        for (int j = 8; j > 0; j--)
        {
          tubeArrays[i].Add(j == height ? "|~~| " : "|  | ");
        }
      }

      for (int j = 0; j < 8; j++)
      {
        o += string.Concat(tubeArrays.Select(p => p[j])) + "\r\n";
      }

      o += string.Concat(Enumerable.Repeat("|__| ", numberOfTubesRequired));

      return o;
    }

    public string V(int n, int[] l)
    {
      var o = "";
      int t = l.Sum(), r = t % 8, f = t / 8, p = r > 0 ? 1 : 0, e = f + p, i = 0, j = 8;
      if (t == 0) return "";
      var h = new List<int>();
      for (i = 0; i < f; i++)
        h.Add(8);
      h.Add(r);
      var w = new List<List<string>>();
      for (i = 0; i < e; i++)
      {
        w.Add(new List<string>()); var x = h[i];
        for (j = 8; j > 0; j--)
          w[i].Add(j == x ? "|~~| " : "|  | ");
      }
      for (j = 0; j < 8; j++)
        o += string.Concat(w.Select(y => y[j])) + "\r\n";
      o += string.Concat(Enumerable.Repeat("|__| ", e));
      return o;
    }

    //Let's golf...
    public string U(int n,int[]l){var o="";int t=l.Sum(),r=t%8,f=t/8,p=r>0?1:0,e=f+p,i=0,j=8;if(t==0)return "";var h=new List<int>();for(i=0;i<f;i++)h.Add(8);h.Add(r);var w=new List<List<string>>();for(i=0;i<e;i++){w.Add(new List<string>());var x=h[i];for(j=8;j>0;j--)w[i].Add(j==x?"|~~| ":"|  | ");}for(j=0;j<8;j++)o+=string.Concat(w.Select(y=>y[j]))+"\r\n";o+=string.Concat(Enumerable.Repeat("|__| ",e));return o;}

    public void ColourOutput(int n, int[] l)
    {
      Console.Title = "Test-Tubes";
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      var o = "";
      int t = l.Sum(), r = t % 8, f = t / 8, p = r > 0 ? 1 : 0, e = f + p, i = 0, j = 8;
      if (t == 0) return;
      var h = new List<int>();
      for (i = 0; i < f; i++)
        h.Add(8);
      h.Add(r);
      var w = new List<List<string>>();
      for (i = 0; i < e; i++)
      {
        w.Add(new List<string>()); var x = h[i];
        for (j = 8; j > 0; j--)
          w[i].Add(j == x ? "|~~| " : "|  | ");
      }
      for (j = 0; j < 8; j++)
      {
        //o += string.Concat(w.Select(y => y[j])) + "\r\n";
        o = string.Concat(w.Select(y => y[j])) + "\r\n";
        //Console.Write(o);

        foreach (var character in o)
        {
          if (character == '~')
          {
            Console.ForegroundColor = ConsoleColor.Blue;
          }
          else
          {
            Console.ForegroundColor = ConsoleColor.Black;
          }

          //ConsoleColor colour = ConsoleColor.Black;

          Console.Write(character);
        }
      }


      //o += string.Concat(Enumerable.Repeat("|__| ", e));

      for (i = 0; i < e; i++)
      {
        Console.Write( "|__| ");
      }


      //Console.Write(string.Concat(Enumerable.Repeat("|__| ", e)));
      //Console.ForegroundColor = ConsoleColor.Black;
      //Console.Write(o);
    }
  }
}