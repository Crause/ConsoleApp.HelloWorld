using System;

namespace ConsoleApp.HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Green;

      Console.WriteLine("Wake up, Neo...");
      System.Threading.Thread.Sleep(2000);

      Console.Clear();
      Console.WriteLine("The matrix has you.");
      System.Threading.Thread.Sleep(2000);

      Console.Clear();
      Console.WriteLine("Follow the white rabbit.");
      System.Threading.Thread.Sleep(2000);

      Console.Clear();
      Console.WriteLine("Knock, knock, Neo.");
      Console.ReadKey();
    }
  }
}
