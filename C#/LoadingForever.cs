using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  class LoadingForever
  {
    public void L()
    {
      Console.Write("Loading...");
      Action<string> l = (a) =>
      {
        Console.SetCursorPosition(11, 0);
        System.Threading.Thread.Sleep(250);
        Console.Write(a);
      };
      while (true)
      {
        l("|");
        l("/");
        l("-");
        l("\\");
      }
    }

    public void M() { Console.Write("Loading..."); Action<string> l = (a) => { Console.SetCursorPosition(11, 0); System.Threading.Thread.Sleep(250); Console.Write(a); }; while (true) { l("|"); l("/"); l("-"); l("\\"); } }

  }
}