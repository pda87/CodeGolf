using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/93441/print-all-integers
  class PAI
  {
    public void f() { for (decimal n = 0; ; n++) { Console.Write(n + ","); if (n > 0)Console.Write(-n + ","); } }

    public void Do()
    {
      decimal n = 0;
      while (true)
      {
        Console.Write(n + ",");
        if (n > 0) Console.Write(-n + ",");
        n++;
      }
    }
  }
}