using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.CodeGolf
{
  //https://codegolf.stackexchange.com/questions/18812/hello-world-fibonacci-distribution
  class HelloWorldFibonacciDistribution
  {
    //Hello world!!! 
    public void H()
    {
      //144 numeric -> Fibonacci #12 = 144
      //Non-numeric allowance = Fibonacci #11 -> 89
      //Currently at 64

      //13 commas

      //If you can put down 144 numbers, you can have 89 chars

      //Need 21 chars

      //int numbersCount = "0072,00101,000108,000108,000111,0000032,00000119,00000111,0000000000114,0000000000108,00000000000000100,00000000000000033,00000000000000033,00000000000000033".Replace(",", "").Length;


      //233 Chars
      //144 Numeric
      //89 Non - Numeric Characters

      /*I suck at CodeGolf!!!*/new List<int>{0072,00101,000108,000108,000111,0000032,00000119,00000111,0000000000114,0000000000108,00000000000000100,00000000000000033,00000000000000033,00000000000000033}.ForEach(c=>Console.Write((char)c));
    }
  }
}