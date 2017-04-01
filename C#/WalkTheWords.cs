using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/99735/walk-the-words
  class WalkTheWords
  {
    //Direction:
    //0 => R, 1 => D, 2 => L, 3 => U
    //public string W(string s)
    //{
    //  var l = s.Length;
    //  var a = new char[2 * l + 1, 2 * l + 1];
    //  int x = 2 * l / 2;
    //  int y = 2 * l / 2;
    //  int d = 0;
    //  for (int i = 0; i < l; i++)
    //  {
    //    switch (s[i])
    //    {
    //      case 'u':
    //      case 'U':
    //        d = 3;
    //        break;
    //      case 'd':
    //      case 'D':
    //        d = 1;
    //        break;
    //      case 'l':
    //      case 'L':
    //        d = 2;
    //        break;
    //      case 'r':
    //      case 'R':
    //        d = 0;
    //        break;
    //      default:
    //        break;
    //    }
    //    a[y, x] = s[i];
    //    switch (d)
    //    {
    //      case 0:
    //        x += 1;
    //        break;
    //      case 1:
    //        y += 1;
    //        break;
    //      case 2:
    //        x -= 1;
    //        break;
    //      case 3:
    //        y -= 1;
    //        break;
    //      default:
    //        break;
    //    }
    //  }
    //  string o = "";
    //  for (int i = 0; i < 2 * l + 1; i++)
    //  {
    //    string t = "";
    //    for (int j = 0; j < 2 * l + 1; j++)
    //      t += a[i, j] + "";
    //    o += t == string.Join("", Enumerable.Repeat('\0', 2 * l + 1)) ? "" : (t + "\r\n");
    //  }
    //  return o;
    //}

    //Direction:
    //0 => R, 1 => D, 2 => L, 3 => U
    public string X(string s)
    {
      var l = s.Length;
      var a = new char[2 * l + 1, 2 * l + 1];
      int x = 2 * l / 2;
      int y = 2 * l / 2;
      int d = 0;
      for (int i = 0; i < l; i++)
      {
        switch (char.ToUpper(s[i]))
        {
          case 'U':
            d = 3;
            break;
          case 'D':
            d = 1;
            break;
          case 'L':
            d = 2;
            break;
          case 'R':
            d = 0;
            break;
        }
        a[y, x] = s[i];
        switch (d)
        {
          case 0:
            x += 1;
            break;
          case 1:
            y += 1;
            break;
          case 2:
            x -= 1;
            break;
          case 3:
            y -= 1;
            break;
        }
      }
      string o = "";
      for (int i = 0; i < 2 * l + 1; i++)
      {
        string t = "";
        for (int j = 0; j < 2 * l + 1; j++)
          t += a[i, j] + "";
        o += t == string.Join("", Enumerable.Repeat('\0', 2 * l + 1)) ? "" : (t + "\r\n");
      }
      return o;
    }

    public string Y(string s) { var l = s.Length; var a = new char[2 * l + 1, 2 * l + 1]; int x = 2 * l / 2; int y = 2 * l / 2; int d = 0; for (int i = 0; i < l; i++) { switch (char.ToUpper(s[i])) { case 'U': d = 3; break; case 'D': d = 1; break; case 'L': d = 2; break; case 'R': d = 0; break; } a[y, x] = s[i]; switch (d) { case 0: x += 1; break; case 1: y += 1; break; case 2: x -= 1; break; case 3: y -= 1; break; } } string o = ""; for (int i = 0; i < 2 * l + 1; i++) { string t = ""; for (int j = 0; j < 2 * l + 1; j++) t += a[i, j] + ""; o += t == string.Join("", Enumerable.Repeat('\0', 2 * l + 1)) ? "" : (t + "\r\n"); } return o; }
  }
}