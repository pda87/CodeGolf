using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //https://codegolf.stackexchange.com/questions/101180/multi-lingual-challenge
  //true false
  //wahr, falsch
  //In C#, bool.ToString() gives "True" or "False"
  //In Java, it's "true" or "false"
  class MultiLingualChallenge
  {
    public String M(Boolean b)
    {
      String s = b + "";
      if (s == "True")
        return "Wahr";
      else if (s == "False")
        return "Falsch";
      else
        return b + "";
    }

    public String N(Boolean b){String s=b+"";if(s=="True")return "Wahr";else if(s=="False")return "Falsch";else return b+"";}
}
}