using System;

namespace Aula22
{
  class Program
  {
    static void Main()
    {
      int[] num = new int[3]{11, 22, 33};

      foreach (int n in num)
      {
        Console.WriteLine(n);
      }
    }
  }
}
