﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/98890/operator-ascii-art/
  class OperatorASCIIArt
  {
    #region Nice Version

    //Nice version
    public string GetASCIIArt(string character, int size)
    {
      switch (character)
      {
        case "+":
          return Plus(size);
        case "=":
          return Equals(size);
        case "-":
          return Minus(size);
        case "/":
          return Divide(size);
        case "x":
          return Multiply(size);
        default:
          return "";
      }
    }

    private string Divide(int size)
    {
      var output = string.Empty;

      for (int i = size; i > 0; i--)
      {
        output += "/".PadLeft(i) + "\r\n";
      }

      return output;
    }

    private string Equals(int size)
    {
      return Repeat("=", size) + Repeat("=", size);
    }

    private string Minus(int size)
    {
      return Repeat("-", size);
    }

    private string Multiply(int size)
    {
      if (size == 1 || size == 2 || size == 3)
      {
        return "x";
      }

      var output = string.Empty;

      int correction = 0;

      string[] rows = new string[size];

      for (int i = size; i > 0; i--)
      {
        if (size - correction - correction < 0)
        {
          output += "x".PadLeft(correction + 1) + "\r\n";
          break;
        }

        string row = string.Join("", Enumerable.Repeat(" ", correction))
          + "x"
          + string.Join("", Enumerable.Repeat(" ", size - correction - correction)) + "x" + "\r\n";

        output += row;
        correction++;
        rows[correction] = row;

        if (i == size / 2)
        {
          break;
        }
      }

      for (int i = rows.Length - 1; i > 0; i--)
      {
        if (string.IsNullOrEmpty(rows[i]))
        {
          continue;
        }
        output += rows[i];
      }

      return size % 2 == 0 ? "Multiply requires an odd number" : output;
    }

    private string Plus(int size)
    {
      var output = string.Empty;

      for (int i = 0; i < size; i++)
      {
        if (i == size / 2)
        {
          output += Repeat("+", size);
        }
        else
        {
          output += "+".PadLeft(size - size / 2, ' ').PadRight(size - size / 2, ' ') + "\r\n";
        }
      }

      return size % 2 == 0 ? "Plus requires an odd number" : output;
    }

    private string Repeat(string repeatedCharacter, int numberOfCharacters)
    {
      return string.Join("", Enumerable.Repeat(repeatedCharacter, numberOfCharacters)) + "\r\n";
    }

    #endregion Nice Version

    #region Code Golf Version

    //Code Golf version
    public string A(string s, int n)
    {
      string O = "";

      Func<string, int, string> R = (a, b) =>
      {
        return string.Join("", Enumerable.Repeat(a, b)) + "\r\n";
      };

      switch (s)
      {
        case "+":
          for (int i = 0; i < n; i++)
          {
            if (i == n / 2)
            {
              O += R("+", n);
            }
            else
            {
              O += "+".PadLeft(n - n / 2, ' ').PadRight(n - n / 2, ' ') + "\r\n";
            }
          }
          return O;
        case "=":
          return R("=", n) + R("=", n);
        case "-":
          return R("-", n);
        case "/":
          for (int i = n; i > 0; i--)
          {
            O += "/".PadLeft(i) + "\r\n";
          }
          return O;
        case "x":
          int x = 0;
          string[] r = new string[n];
          for (int i = n; i > 0; i--)
          {
            if (n - x - x < 0)
            {
              O += "x".PadLeft(x + 1) + "\r\n";
              break;
            }
            string row = string.Join("", Enumerable.Repeat(" ", x))
              + "x"
              + string.Join("", Enumerable.Repeat(" ", n - x - x)) + "x" + "\r\n";
            O += row;
            x++;
            r[x] = row;
            if (i == n / 2)
            {
              break;
            }
          }
          for (int i = r.Length - 1; i > 0; i--)
          {
            if (string.IsNullOrEmpty(r[i]))
            {
              continue;
            }
            O += r[i];
          }
          return O;
        default:
          return "";
      }
    }
  }

  #endregion Code Golf Version
}