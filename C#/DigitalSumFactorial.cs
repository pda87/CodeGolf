using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/100823/factorial-digit-sum
  class DigitalSumFactorial
  {
    //public long F(int n)
    //{
    //  long f = 1;
    //  int s = 0, i;
    //  for (i = n; i >= 2; i--)
    //    f *= i;
    //  f.ToString().ToList().ForEach(c => s += int.Parse(c+""));
    //  return s;
    //}

    public long F(int n)
    {
      long f = 1;
      int s = 0;
      for (; n > 1;)
        f *= n--;
      foreach (var c in f.ToString().ToList())
        s += int.Parse(c + "");
      return s;
    }

    public long G(int n){long f=1;int s=0;for(;n>1;)f*=n--;foreach(var c in f.ToString().ToList())s+=int.Parse(c+"");return s;}

    //public long G(int n){long f=1;int s=0,i;for(i=n;i>=2;i--)f*=i;f.ToString().ToList().ForEach(c =>s+=int.Parse(c+""));return s;}

    public Int64 Int64Version(int n)
    {
      long f = 1;
      Int64 s = 0, i;

      for (i = n; i >= 2; i--)
        f *= i;

      f.ToString().ToList().ForEach(c => s += int.Parse(c + ""));

      return s;
    }

    public static void Func()
    {
      Func<int, long> d = (n) => {
        long f = 1;
        int s = 0;
        for (; n > 1;)
          f *= n--;
        foreach (var c in f.ToString().ToList())
          s += int.Parse(c + "");
        return s;
      };

      Func<int,long>e=(n)=>{long f=1;int s=0;for(;n>1;)f*=n--;f.ToString().ToList().ForEach(c => s += int.Parse(c + ""));return s;};

      Console.WriteLine(d(20));
      Console.WriteLine(e(20));
      Console.ReadLine();
    }
  }
}