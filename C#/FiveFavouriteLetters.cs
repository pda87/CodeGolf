using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/99913/5-favorite-letters
  class FiveFavouriteLetters
  {
    /*

 SSSS     H   H      AAA      RRRR      PPPP 
S         H   H     A   A     R   R     P   P
 SSS      HHHHH     AAAAA     RRRR      PPPP 
    S     H   H     A   A     R  R      P    
SSSS      H   H     A   A     R   R     P    

    */


    public void F()
    {
      string g = "     ", h = "H   H", A = "A   A",B= h + "|" + A;
      Func<string, string> j = (a) => { return a.Replace("|", g) + "\r\n"; };
      Console.Write(j(" SSSS|"+h+"| AAA |RRRR |PPPP") +
      j("S    |"+B+ "|R   R|P   P") +
      j(" SSS |HHHHH|AAAAA|RRRR |PPPP") +
      j("    S|"+B+"|R  R |P") +
      j("SSSS |"+B+"|R   R|P"));
    }

    public void OutputToTextFile()
    {
      string g = "     ", h = "H   H", A = "A   A", B = h + "|" + A;

      Func<string, string> j = (a) => { return string.Join(g, a.Split('|')) + "\r\n"; };

      var STRING = j(" SSSS|" + h + "| AAA |RRRR |PPPP") +
      j("S    |" + B + "|R   R|P   P") +
      j(" SSS |HHHHH|AAAAA|RRRR |PPPP") +
      j("    S|" + B + "|R  R |P") +
      j("SSSS |" + B + "|R   R|P");

      using (StreamWriter sw = new StreamWriter("FiveFavouriteLetters.txt"))
      {
        sw.Write(STRING);
      }
      
    }

    public void G(){string g="     ",h="H   H",A="A   A",B=h+"|"+A;Func<string,string>j=(a)=>{return a.Replace("|",g)+"\r\n";};Console.Write(j(" SSSS|"+h+"| AAA |RRRR |PPPP")+j("S    |"+B+"|R   R|P   P")+j(" SSS |HHHHH|AAAAA|RRRR |PPPP")+j("    S|"+B+"|R  R |P")+j("SSSS |"+B+"|R   R|P"));}
  }
}