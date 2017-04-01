using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/64994/golf-yourself-a-beer
  class GolfYourselfABeer
  {
    public string f()
    {
      var l = "\n";

      string top = " __________" + l;

      string glass = @"|          |\" + l +
                     @"|          | \" + l +
                     @"|          |} |" + l +
                     @"|          | /" + l +
                     @"|          |/" + l +
                     @"\__________/";

      

      glass = top + glass;

      return glass;
    }
  }
}