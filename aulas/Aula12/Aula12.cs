using System;

namespace Aula12
{
  class Program
  {
    static void Main()
    {
      int nota = 0;
      string resultado = "";

      Console.WriteLine("Digite a nota final: ");
      nota = Convert.ToInt32(Console.ReadLine());

      if (nota < 0 | nota > 100)
      {
        resultado = "ERRO: Nota inválida";
      } else if (nota >= 70)
      {
        resultado = "Aprovado";
      } else
      {
        resultado = "Reprovado";
      }

      Console.WriteLine("Aluno(a): {0}", resultado);
    }
  }
}
