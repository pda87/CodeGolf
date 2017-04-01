using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //Swap The Alphabet
  //https://codegolf.stackexchange.com/questions/68504/swap-the-alphabet?page=2&tab=active#tab-top
  class Atbash
  {
    public string A(string s)
    {
      string a = "abcdefghijklmnopqrstuvwxyz",
        z = string.Concat(a.Reverse()), o = "";
      s.ToList().ForEach(c => o += !z.Contains(char.ToLower(c)) ? c :
      char.IsLower(c) ? z[a.IndexOf(c)] :
      char.ToUpper(z[a.IndexOf(char.ToLower(c))]));
      return o;
    }

    public string B(string s){string a="abcdefghijklmnopqrstuvwxyz",z=string.Concat(a.Reverse()),o="";s.ToList().ForEach(c=>o+=!z.Contains(char.ToLower(c))?c:char.IsLower(c)?z[a.IndexOf(c)]:char.ToUpper(z[a.IndexOf(char.ToLower(c))]));return o;}
  }
}