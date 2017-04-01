using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/97049/print-the-greek-alphabet
  class PrintTheGreekAlphabet
  {
    //var greeksUpper = "ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩ";
    //var greeksLower = "αβγδεζηθικλμνξοπρστυφχψω";

    public string G(bool u){var s = string.Empty;for (int i = 145; i <= 169; i++){s = s + Encoding.UTF8.GetString(new byte[] { 206, Convert.ToByte(i) });}return u ? s : s.ToLower();}
    public string F(bool u){var s=string.Empty;for(int i=145;i<=169;i++){s=s+Encoding.UTF8.GetString(new byte[]{206,Convert.ToByte(i)});}return u?s:s.ToLower();}
  }
}