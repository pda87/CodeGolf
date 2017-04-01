using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  class StripAComma
  {
    public string f(string filePath, int column)
    {
      var a = System.IO.File.ReadAllLines(filePath).ToList();

      foreach (var b in a)
      {
        var c = b.Split(',');

        
      }

      return "";
    }
  }
}
