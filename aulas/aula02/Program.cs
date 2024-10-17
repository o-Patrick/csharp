using System;

namespace Aula02
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Olá, mundo!");
      if (args.Length > 0)
      {
        Console.WriteLine(args.GetValue(0));
      }
    }
  }
}