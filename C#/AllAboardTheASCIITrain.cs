using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/101684/all-aboard-the-ascii-train
  class AllAboardTheASCIITrain
  {
    /*

    o O O   ___     ___     ___     ___     ___     ___     ___     ___     ___  
   o       | C |   | O |   | D |   | E |   |   |   | G |   | O |   | L |   | F | 
  TS__[O]  |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___| 
 {======|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|
./o--000'"`-0-0-'"


          o O O 
         o      
        TS__[O] 
       {======| 
      ./o--000' 

         ___  
        | C | 
        |___| 
      _|"""""|
      "`-0-0-'

         ___  
        | # | 
        |___| 
      _|"""""|
      "`-0-0-'

     o O O   ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___     ___  
   o        | P |   | r |   | o |   | g |   | r |   | a |   | m |   | m |   | i |   | n |   | g |   |   |   | P |   | u |   | z |   | z |   | l |   | e |   | s |   |   |   | & |   |   |   | C |   | o |   | d |   | e |   |   |   | G |   | o |   | l |   | f |   
   TS__[O]  |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___|   |___| 
  {======|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|_|"""""|
./ o--000'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'"`-0-0-'


  */

    //public string T(string s)
    //{
    //  Func<string, int, string> p = (a, b) => { return a.PadLeft(a.Length + b); };
    //  Func<string, int, string> q = (a, b) => { return a.PadRight(a.Length + b); };
    //  var o = new string[] { p("o O O", 5), q(p("o", 3), 8), p("TS__[O]", 3),
    //    p("{======|", 2), "./ o--000'" };


    //  for (int i = 0; i < s.Length; i++)
    //  {
    //    o[0] += q("   ___", 2);
    //    o[1] += "| # |   ".Replace("#", s[i]+"");
    //    o[2] += q("  |___|", 1);
    //    o[3] +="_|\"\"\"\"\"|";
    //    o[4] += "\"`-0-0-'";
    //  }

    //  return string.Join("\r\n",o);
    //}

    public string T(string s)
    {
      var o = new string[] { "     o O O", "   o        ", "   TS__[O]",
        "  {======|", "./ o--000'" };

      for (int i = 0; i < s.Length; i++)
      {
        o[0] += "   ___  ";
        o[1] += "| # |   ".Replace("#", s[i] + "");
        o[2] += "  |___| ";
        o[3] += "_|\"\"\"\"\"|";
        o[4] += "\"`-0-0-'";
      }

      return string.Join("\r\n", o);
    }

    public string U(string s){var o=new string[]{"     o O O","   o        ","   TS__[O]","  {======|","./ o--000'" };for(int i=0;i<s.Length;i++){o[0]+="   ___  ";o[1]+="| # |   ".Replace("#",s[i]+"");o[2]+="  |___| ";o[3]+="_|\"\"\"\"\"|";o[4]+="\"`-0-0-'";}return string.Join("\r\n",o);
    }

    //public string U(string s){Func<string,int,string>p=(a,b)=>{return a.PadLeft(a.Length+b);};Func<string,int,string>q=(a,b)=>{return a.PadRight(a.Length+b);};var o=new string[]{p("o O O",5),q(p("o",3),8),p("TS__[O]",3),p("{======|",2),"./ o--000'"};for(int i=0;i<s.Length;i++){o[0]+=q("   ___",2);o[1]+="| # |   ".Replace("#",s[i]+"");o[2]+=q("  |___|",1);o[3]+="_|\"\"\"\"\"|";o[4]+="\"`-0-0-'";}return string.Join("\r\n",o);}
  }
}