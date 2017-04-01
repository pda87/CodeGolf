using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{

  //https://codegolf.stackexchange.com/questions/102327/help-my-maniacal-wife-decorate-our-christmas-tree

  enum WifeMode
  {
    Maniacal
  }

  class ChristmasTreeDecorating
  {
    public void GIFChristmasTree()
    {
      Console.Title = "Merry Christmas";
      Console.WindowHeight = Console.LargestWindowHeight;
      Console.WindowWidth = Console.LargestWindowWidth;

      var castAdjustment = 0;

      while (true)
      {
        Console.Clear();
        ColourTree(42, 9, castAdjustment);
        castAdjustment++;
        if (castAdjustment == 6)
        {



          castAdjustment = 0;
        }


        Console.ReadLine();
        Thread.Sleep(500);
      }
    }

    public void ColourTree(int n, int k, int castAdjustment)
    {
      string o = "", x;
      int j = 1, i, m;

      for (i = 1; i <= n; i++)
      {
        o = string.Concat(Enumerable.Repeat("^ ", i)).PadLeft(n + i) + "\r\n";

        Console.ForegroundColor = ConsoleColor.Green;
        string padString = "                                   ";

        Console.Write(padString + o);

        m = 0;
        x = "";

        if (i < n)
        {
          while (m < i + 1)
          {
            if (j > k) j = 1;
            x += j++ + " ";
            m++;
          }

          //o += x.PadLeft(n + i + 1) + "\r\n";
          o = x.PadLeft(n + i + 1) + "\r\n";


          Console.Write(padString);

          foreach (var character in o)
          {
            ConsoleColor color;

            if (char.IsNumber(character))
            {
              color = (ConsoleColor)int.Parse(character.ToString()) + castAdjustment;
            }
            else
            {
              color = ConsoleColor.Green;
            }

            Console.ForegroundColor = color;
            Console.Write(character.ToString());
          }

          //Console.Write("\r\n");
        }
      }
    }

    public void ColourTree(int n, int k, WifeMode wifeMode = WifeMode.Maniacal)
    {
      string o = "", x;
      int j = 1, i, m;

      for (i = 1; i <= n; i++)
      {
        o = string.Concat(Enumerable.Repeat("^ ", i)).PadLeft(n + i) + "\r\n";

        Console.ForegroundColor = ConsoleColor.Green;
        string padString = "                                   ";

        Console.Write(padString + o);

        m = 0;
        x = "";

        if (i < n)
        {
          while (m < i + 1)
          {
            if (j > k) j = 1;
            x += j++ + " ";
            m++;
          }

          //o += x.PadLeft(n + i + 1) + "\r\n";
          o = x.PadLeft(n + i + 1) + "\r\n";


          Console.Write(padString);

          foreach (var character in o)
          {
            ConsoleColor color;

            if (char.IsNumber(character))
            {
              color = (ConsoleColor)int.Parse(character.ToString()) + 6;
            }
            else
            {
              color = ConsoleColor.Green;
            }

            Console.ForegroundColor = color;
            Console.Write(character.ToString());
          }

          //Console.Write("\r\n");
        }
      }
    }

    public void ColourTreeWithSnow(int n, int k)
    {

      Console.ForegroundColor = ConsoleColor.Green;
      Console.SetCursorPosition(0, 0);

      string o = "", x;
      int j = 1, i, m;

      for (i = 1; i <= n; i++)
      {
        o = string.Concat(Enumerable.Repeat("^ ", i)).PadLeft(n + i) + "\r\n";

        Console.ForegroundColor = ConsoleColor.Green;

        //string padString = "                                   ";

        Console.CursorLeft =10;
        Console.Write(o);

        m = 0;
        x = "";

        if (i < n)
        {
          while (m < i + 1)
          {
            if (j > k) j = 1;
            x += j++ + " ";
            m++;
          }

          //o += x.PadLeft(n + i + 1) + "\r\n";
          o = x.PadLeft(n + i + 1) + "\r\n";


          //Console.Write(padString);

          Console.CursorLeft = 10;

          foreach (var character in o)
          {
            ConsoleColor color;

            if (char.IsNumber(character))
            {
              color = (ConsoleColor)int.Parse(character.ToString()) + 6;
            }
            else
            {
              color = ConsoleColor.Green;
            }

            Console.ForegroundColor = color;
            Console.Write(character.ToString());
          }
        }
      }

      //var snow = string.Concat(Enumerable.Repeat(".   . .        .  .         .  .        . . .         . . . . . ", 100));

      //Console.ForegroundColor = ConsoleColor.White;

      //Console.SetCursorPosition(0, 0);
      //Console.Write(snow);
    }

    public string C(int n, int k, WifeMode wifeMode = WifeMode.Maniacal)
    {
      string o = "", x;
      int j = 1, i=1, m;

      for (; i <= n; i++)
      {
        o += string.Concat(Enumerable.Repeat("^ ", i)).PadLeft(n + i) + "\n";

        m = 0;
        x = "";

        if (i < n)
        {
          while (m < i + 1)
          {
            if (j > k) j = 1;
            x += j++ + " ";
            m++;
          }

          o += x.PadLeft(n + i + 1) + "\n";
        }
      }

      return o;
    }

    public string D(int n,int k){string o="",x;int j=1,i=1,m;for(;i<=n;i++){o+=string.Concat(Enumerable.Repeat("^ ",i)).PadLeft(n+i)+"\n";m=0;x="";if(i<n){while(m<i+1){if(j>k)j=1;x+=j+++" ";m++;}o+=x.PadLeft(n+i+1)+"\n";}}return o;}
  }
}