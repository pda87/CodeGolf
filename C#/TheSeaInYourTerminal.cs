using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //https://codegolf.stackexchange.com/questions/102719/the-sea-in-your-terminal
  class TheSeaInYourTerminal
  {
    /*

    Wave:
            **  
        ****    
     *****      
   **   **      
 **      **     
*          *****

  */

    public void Movement()
    {
      //string thingToMove = string.Join("\r\n", new string[] { "*", "*", "*", "*", "*", "*" });

      int padLeftInt = 0;

      while (true)

      {
        Console.Clear();
        string thingToMove = string.Join("\r\n", new string[] { "*".PadLeft(padLeftInt + 1), "*".PadLeft(padLeftInt + 1), "*".PadLeft(padLeftInt + 1), "*".PadLeft(padLeftInt + 1), "*".PadLeft(padLeftInt + 1), "*".PadLeft(padLeftInt + 1) });
        Console.WriteLine(thingToMove);
        Thread.Sleep(100);
        padLeftInt++;

        if (padLeftInt == 40)
        {
          padLeftInt = 0;
        }
      }
    }
    public void WaveMovement()
    {
      //string thingToMove = string.Join("\r\n", new string[] { "*", "*", "*", "*", "*", "*" });

      int padLeftInt = 0;

      while (true)

      {
        Console.Clear();

        string thingToMove = string.Join("\r\n", new string[]

        /*

            **  
        ****    
     *****      
   **   **      
 **      **     
*          *****

  */



        { "            **  ".PadLeft(padLeftInt + 1),
          "        ****    ".PadLeft(padLeftInt + 1),
          "     *****      ".PadLeft(padLeftInt + 1),
          "   **   **      ".PadLeft(padLeftInt + 1),
          " **      **     ".PadLeft(padLeftInt + 1),
          "*          *****".PadLeft(padLeftInt + 1) });

        //string thingToMove = string.Join("\r\n", new string[] { "*".PadLeft(padLeftInt + 1), "*".PadLeft(padLeftInt + 1), "*".PadLeft(padLeftInt + 1), "*".PadLeft(padLeftInt + 1), "*".PadLeft(padLeftInt + 1), "*".PadLeft(padLeftInt + 1) });
        Console.WriteLine(thingToMove);
        Thread.Sleep(100);
        padLeftInt++;

        if (padLeftInt == 60)
        {
          padLeftInt = 0;
        }
      }
    }

    public void SeaMovement()
    {
      int padLeftInt = 0;
      while (true)

      {
        Console.Clear();
        var line1 = string.Concat(Enumerable.Repeat("            **  ", 5));
        var line2 = string.Concat(Enumerable.Repeat("        ****    ", 5));
        var line3 = string.Concat(Enumerable.Repeat("     *****      ", 5));
        var line4 = string.Concat(Enumerable.Repeat(" **      **     ", 5));
        var line5 = string.Concat(Enumerable.Repeat("*          *****", 5));


        /*

            **  
        ****    
     *****      
   **   **      
 **      **     
*          *****

  */


        string thingToMove = string.Join("\r\n", new string[]
        {
          (line1.Substring(16-padLeftInt) + line1).Substring(0, 80),
          (line2.Substring(16-padLeftInt) +line2).Substring(0, 80),
          (line3.Substring(16-padLeftInt) + line3).Substring(0, 80),
          (line4.Substring(16-padLeftInt) + line4).Substring(0, 80),
          (line5.Substring(16-padLeftInt) + line5).Substring(0, 80) }
        );

        Console.WriteLine(thingToMove);
        Thread.Sleep(100);
        padLeftInt++;

        if (padLeftInt == 16)
        {
          padLeftInt = 0;
        }
      }
    }

    public void S()
    {
      Func<string, string> r =(a) => { return string.Concat(Enumerable.Repeat(a, 5)); };
      Func<string, int, string> s = (b, i) => { return (b.Substring(16 - i) + b).Substring(0, 80); };
      int p = 0;
      while (true)
      {
        Console.Clear();
        var line1 = string.Concat(Enumerable.Repeat("            **  ", 5));
        var line2 = string.Concat(Enumerable.Repeat("        ****    ", 5));
        var line3 = string.Concat(Enumerable.Repeat("     *****      ", 5));
        var line4 = string.Concat(Enumerable.Repeat(" **      **     ", 5));
        var line5 = string.Concat(Enumerable.Repeat("*          *****", 5));


        string w = string.Join("\r\n", new string[]
        {
          (line1.Substring(16-p) + line1).Substring(0, 80),
          (line2.Substring(16-p) +line2).Substring(0, 80),
          (line3.Substring(16-p) + line3).Substring(0, 80),
          (line4.Substring(16-p) + line4).Substring(0, 80),
          (line5.Substring(16-p) + line5).Substring(0, 80) }
        );

        Console.WriteLine(w);
        Thread.Sleep(100);
        p++;

        if (p == 16)
        {
          p = 0;
        }
      }
    }

    public void T()
    {
      Func<string, string> r = (a) => { return string.Concat(Enumerable.Repeat(a, 5)); };
      Func<string, int, string> s = (b, i) => { return (b.Substring(16 - i) + b).Substring(0, 80); };
      int p = 0;
      while (true)
      {
        Console.Clear();
        //var l1 = string.Concat(Enumerable.Repeat("            **  ", 5));
        //var l2 = string.Concat(Enumerable.Repeat("        ****    ", 5));
        //var l3 = string.Concat(Enumerable.Repeat("     *****      ", 5));
        //var l4 = string.Concat(Enumerable.Repeat(" **      **     ", 5));
        //var l5 = string.Concat(Enumerable.Repeat("*          *****", 5));
        var l1 = r("            **  ");
        var l2 = r("        ****    ");
        var l3 = r("     *****      ");
        var l4 = r(" **      **     ");
        var l5 = r("*          *****");


        string w = string.Join("\r\n", new string[]
        {
          s(l1, p),
          s(l2, p),
          s(l3, p),
          s(l4, p),
          s(l5, p),
        }

          //(l1.Substring(16-p) + l1).Substring(0, 80),
          //(l2.Substring(16-p) +l2).Substring(0, 80),
          //(l3.Substring(16-p) + l3).Substring(0, 80),
          //(l4.Substring(16-p) + l4).Substring(0, 80),
          //(l5.Substring(16-p) + l5).Substring(0, 80) }
        //(l1.Substring(16-p) + l1).Substring(0, 80),
        //(l2.Substring(16-p) +l2).Substring(0, 80),
        //(l3.Substring(16-p) + l3).Substring(0, 80),
        //(l4.Substring(16-p) + l4).Substring(0, 80),
        //(l5.Substring(16-p) + l5).Substring(0, 80) }
        );

        Console.WriteLine(w);
        Thread.Sleep(100);
        p++;

        if (p == 16)
        {
          p = 0;
        }
      }
    }

    public void U()
    {
      Func<string, string> r = a => string.Concat(Enumerable.Repeat(a, 5));
      Func<string, int, string> s = (b, i) => (b.Substring(16 - i) + b).Substring(0, 80);

      int p = 0;
      for(;;)
      {
        Console.Clear();
        Console.WriteLine(
          string.Join("\r\n", new string[]
        {
          s(r("            **  "), p),
          s(r("        ****    "), p),
          s(r("     *****      "), p),
          s(r(" **      **     "), p),
          s(r("*          *****"), p),})
          );
        Thread.Sleep(100);
        p++;

        if (p == 16)
          p = 0;
      }
    }
    public void V(){Func<string,string>r=a=>string.Concat(Enumerable.Repeat(a,5));Func<string,int,string>s=(b,i)=>(b.Substring(16-i)+b).Substring(0,80);int p=0;for(;;){Console.Clear();Console.WriteLine(string.Join("\r\n",new string[]{s(r("            **  "),p),s(r("        ****    "),p),s(r("     *****      "),p),s(r(" **      **     "),p),s(r("*          *****"),p),}));Thread.Sleep(100);p++;if(p==16)p=0;}}

    public void W()
    {
      Func<string, string> r = a => string.Concat(Enumerable.Repeat(a, 5));
      Func<string, int, string> s = (b, i) => (b.Substring(16 - i) + b).Substring(0, 80);

      int p = 0;
      for (;;)
      {
        Console.Clear();
        var w = string.Join("\r\n", new string[]
        {
          s(r("            **  "), p),
          s(r("        ****    "), p),
          s(r("     *****      "), p),
          s(r(" **      **     "), p),
          s(r("*          *****"), p),});

        Console.WriteLine(w);
        Console.ReadLine();
        Thread.Sleep(100);
        p++;

        if (p == 16)
          p = 0;
      }
    }

  }
}