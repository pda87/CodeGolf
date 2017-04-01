using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/97713/print-the-digital-root
  class PrintTheDigitalRoot
  {
    public string R(string i)
    {
      while (i.Length > 1)
      {
        i = i.Sum(o => int.Parse(o + ""))+"";
      }

      return i;
    }

    public string S(string i){while(i.Length>1){i=i.Sum(o=>int.Parse(o+""))+"";}return i;}
  }
}