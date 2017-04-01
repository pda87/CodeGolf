using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/58732/make-me-a-scrolling-marquee
  class ScrollingMarquee
  {
    public void f(string s)
    {
      var chars = s.ToCharArray();

      int i = 0;

      while (true)
      {
        if (i == 0)
        {
          Console.WriteLine(s);
        }

        Console.SetCursorPosition(i, 0);
        Console.Write(chars[i]);
        Thread.Sleep(100);
        i++;

        if (i == chars.Length - 1)
        {
          Console.Clear();
          i = 0;
        }
      }
    }
  }
}