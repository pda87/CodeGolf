using System;
using System.Text;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/90916/how-does-math-work-in-anastasiyas-world
  class AnastasiyaMath
  {
    public string A(string i)
    {
      int n = 1;
      int a = 0;
      var t = i.Contains("(+)");
      var b = i.Split('(');
      int f = int.Parse(b[0]);
      int s = t ? int.Parse(b[1].Replace("+)", "")) : int.Parse(b[1].Replace("*)", ""));
      if (t)
        a = f + s;
      else
        a = f * s;
      while (Encoding.ASCII.GetByteCount(a.ToString()) > 1)
      {
        var c = a.ToString();
        if (t)
          a = 0;
        else
          a = 1;

        foreach (var ch in c)
        {
          if (t)
            a += int.Parse(ch.ToString());
          else
            a *= int.Parse(ch.ToString());
        }
        n++;
      }
      return a + " : " + n;
    }
  }
}



//Func<string, int> d = (string str) => { return int.Parse(str); };