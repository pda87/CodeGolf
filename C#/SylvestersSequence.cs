using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //http://codegolf.stackexchange.com/questions/91154/sylvesters-sequence
  class SylvestersSequence
  {
    public int f(int n)
    {
      var a = new int[n];

      int b = 1;

      for (int i = 0; i < a.Length; i++)
      {
        a[i] = b;

        b = 1;

        a.ToList().GetRange(0, i).ForEach(o => b *= o);

        a[i] = b + 1;
      }

      return a[n - 1]; 
    }
  }
}

//public int s(int n){var a=new int[n];int b=1;for(int i=0;i<a.Length;i++){a[i]=b;b=1;a.ToList().GetRange(0,i).ForEach(o=>b*=o);a[i]=b+1;}return a[n-1];}
