using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using X = System.Console;
using Y = System.ConsoleKey;
namespace A.CodeGolf
{
  class MakeASimplifiedTamagotchiPet
  {
    public void T()
    { 
      int HE = 100, M = 100, F = 10, HU = 0, S = 0, P = 0;

      Action w = () => {
        X.Clear();X.WriteLine(string.Format("Health: {0}\r\nMoney: {1}\r\nFood: {2}\r\nHunger: {3}\r\nSleep: {4}\r\nPotions: {5}\r\n",
        HE, M,F, HU, S, P)); };

      while (HE > 0)
      {
        if (X.KeyAvailable)
        {
          var i = X.ReadKey();

          if (i.Key == Y.F)
          {
            F -= F > 0 ? 1 : 0;
            HU -= HU > 8 && F > 0 ? 9 : 0;
            w();
          }
          if (i.Key == Y.S)
          {
            S = 0;
            w();
          }
          if (i.Key == Y.P)
          {
            HE += P > 0 ? 9 : 0;
            P -= P > 0 ? 1 : 0;
            w();
          }
          if (i.Key == Y.B)
          {
            P += M > 9 ? 1 : 0;
            M -= M > 8 ? 9 : 0;
            w();
          }
          if (i.Key == Y.T)
          {
            F += M > 8 ? 1 : 0;
            M -= M > 8 ? 9 : 0;
            w();
          }
        }
        

        HU++;
        S++;
        HE -= HU >= 80 ? 1 : 0;
        HU += S >= 80 ? 9 : 0;
        S = S >= 80 ? 0 : S;
        M += HE >= 80 ? 1 : 0;

        System.Threading.Thread.Sleep(500);
        w();
      }
    }
  }
}