using System;

namespace Aula20
{
  class Program
  {
    static void Main()
    {
      int[] num = new int[10];
      int i = 0;

      while (i < num.Length) {
        num[i] = i;
        Console.WriteLine("Valor na posição {0}: {1}", i, num[i]);
        i++;
      }
    }
  }
}
