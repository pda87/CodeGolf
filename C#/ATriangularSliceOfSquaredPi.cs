using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://stackoverflow.com/questions/11677369/how-to-calculate-pi-to-n-number-of-places-in-c-sharp-using-loops
  //http://www.mathpropress.com/stan/bibliography/spigot.pdf
  class ATriangularSliceOfSquaredPi
  {
    //http://www.piday.org/million/
    //const string p = "1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091456485669234603486104543266482133936072602491412737245870066063155881748815209209628292540917153643678925903600113305305488204665213841469519415116094330572703657595919530921861173819326117931051185480744623799
    public string CalculatePi(int digits)
    {
      digits++;

      uint[] x = new uint[digits * 10 / 3 + 2];
      uint[] r = new uint[digits * 10 / 3 + 2];

      uint[] pi = new uint[digits];

      for (int j = 0; j < x.Length; j++)
        x[j] = 20;

      for (int i = 0; i < digits; i++)
      {
        uint carry = 0;
        for (int j = 0; j < x.Length; j++)
        {
          uint num = (uint)(x.Length - j - 1);
          uint dem = num * 2 + 1;

          x[j] += carry;

          uint q = x[j] / dem;
          r[j] = x[j] % dem;

          carry = q * num;
        }


        pi[i] = (x[x.Length - 1] / 10);


        r[x.Length - 1] = x[x.Length - 1] % 10; ;

        for (int j = 0; j < x.Length; j++)
          x[j] = r[j] * 10;
      }

      var result = "";

      uint c = 0;

      for (int i = pi.Length - 1; i >= 0; i--)
      {
        pi[i] += c;
        c = pi[i] / 10;

        result = (pi[i] % 10).ToString() + result;
      }

      return result;
    }


    public IEnumerable<string> f(int m, int t)
    {
      var a = new string[m, m];

      var pi = CalculatePi((m * m) + 1);

      var b = pi.Substring(1, pi.Length - 2);

      var c = 0;

      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < m; j++)
        {
          a[i, j] = b[c] + "";
          c++;
        }
      }

      c = 0;

      while (t > 0)
      {
        for (int i = t; i > 0; i--)
        {
          yield return a[c, m - i];
        }
        t--;
        c++;
      }
    }
  }
}