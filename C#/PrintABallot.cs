using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/99118/print-a-ballot
  class PrintABallot
  {
    public string B(string s)
    {
      var h = "Hilary Clinton".PadRight(17);
      var d = "Donald Trump".PadRight(17);
      var r = "===     ===>\n";
      var c = r.Replace(" ", "-");
      var b = "____________".PadRight(17);
      return s == h.Trim() ? s.PadRight(17) + c + d + r + b + r :
        s == d.Trim() ? h + r + d + c + b + r :
          h + r + d + r + s.PadRight(17) + c;
    }

    public string D(string s){var h="Hilary Clinton".PadRight(17);var d="Donald Trump".PadRight(17);var r="===     ===>\n";var c=r.Replace(" ", "-");var b="____________".PadRight(17);return s==h.Trim()?s.PadRight(17)+c+d+r+b+r:s==d.Trim()?h+r+d+c+b+r:h+r+d+r+s.PadRight(17)+c;}
  }
}
