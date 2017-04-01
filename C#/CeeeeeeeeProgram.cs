using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //I HATE THIS
  //https://codegolf.stackexchange.com/questions/100486/make-a-ceeeeeeee-program
  class CeeeeeeeeProgram
  {
    public void C(string s, string a)
    {
      //n = 9 for first test, so should output "Meeeeeeeee"
      int n = s.Where(o => o == a.ToCharArray()[0]).Count();
      int i = 1;
      var c = s;
      int d = 0;

      var indices = new List<int>();

      for (int j = 0; j < s.Length; j++)
        if (s[j] == a.ToCharArray()[0])
          indices.Add(j);

      while (c.Length > 1 + n)
      {

        if (indices.Contains(i -2))
        {
          var bx = c.First()+"" + c[i - 3] + "" + s.Remove(0, i);

          //c = c.First() + c[i - 1] + "";
        }
        else
        c = c.First() + "" + s.Remove(0, i);
        i++;
        Console.WriteLine(c + "\r\n");
      }
    }

    //public IEnumerable<string> C(string s, string a)
    //{
    //  //n = 9 for first test, so should output "Meeeeeeeee"
    //  int n = s.Where(o => o == a.ToCharArray()[0]).Count();
    //  int b = 0;
    //  int i = 1;

    //  while (s.Length != 1 + n)
    //  {
    //    if (s[n] == a.ToCharArray()[0])
    //    {
    //      b++;
    //    }

    //    s = s.Substring(0, 1) + s.Substring(i, s.Length - 1);
    //    //s.ToList().RemoveAt(i);
    //    i++;
    //    yield return s;
    //  }
    //}
  }
}