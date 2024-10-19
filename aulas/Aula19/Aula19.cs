using System;

namespace Aula18
{
  class Program
  {
    static void Main()
    {
      int[] num = new int[10];

      for (int i = 0; i < num.Length; i++)
      {
        num[i] = i;
        Console.WriteLine("Valor na posição {0}: {1}", i, num[i]);
      }
    }
  }
}
