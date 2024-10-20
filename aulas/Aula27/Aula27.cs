using System;

namespace Aula27
{
  class Program
  {
    static void Main()
    {
      double n1 = 0;
      double n2 = 0;

      Console.Write("Insira o primeiro valor: ");
      n1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Insira o segundo valor: ");
      n2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("A soma dos valores é: {0}", Soma(n1));
    } // method Main

    static double Soma(params double[] n)
    {
      double res = 0;
      if (n.Length < 1)
      {
        Console.WriteLine("Não existem valores a serem somados");
      } else if (n.Length < 2)
      {
        Console.WriteLine("Valores insuficientes para soma: {0}", n.Length);
      } else
      {
        for (int i = 0; i < n.Length; i++)
        {
          res += n[i];
        }
      }

      return res;
    } // method Soma
  } // class Progran
} // namespace
