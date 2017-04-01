using System;

namespace Scratchpad.CodeGolf
{
  //https://codegolf.stackexchange.com/questions/64870/legen-wait-for-it
  class LegenWaitForIt
  {



    public void L()
    {
      var d = DateTime.Now;
      Console.Write("Legen... wait for it...");
      while (DateTime.Now.Hour != d.Hour + 1) { }
      Console.Write("dary!");
    }








    public void M(){var d=DateTime.Now;Console.Write("Legen... wait for it...");while(DateTime.Now.Hour!=d.Hour+1){}Console.Write("dary!");}
  }
}