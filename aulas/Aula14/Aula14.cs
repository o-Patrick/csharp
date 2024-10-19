using System;

namespace Aula13
{
  class Program
  {
    static void Main()
    {
      int tempo = 0;
      char transporte = 'n';
      string resultado = "";
      char reiniciar = 'n';

      inicio:

      Console.Clear();

      Console.WriteLine("Escolha o meio de transporte: [a] Avião | [c] Carro | [o] Ônibus");
      transporte = char.Parse(Console.ReadLine());
      
      switch (transporte)
      {
        case 'a':
        case 'A':
          tempo = 50;
          break;
        case 'c':
        case 'C':
          tempo = 480;
          break;
        case 'o':
        case 'O':
          tempo = 660;
          break;
        default:
          tempo = -1;
          break;
      }

      if (tempo < 0)
      {
        resultado = "Transporte indisponível!";
      } else {
        resultado = "Tempo para o transporte escolhido: " + tempo + " minutos";
      }

      Console.WriteLine(resultado);

      pergunta:

      Console.WriteLine("Deseja reiniciar o programa? [s] Sim | [n] Não");
      reiniciar = char.Parse(Console.ReadLine());

      if (reiniciar != 's' & reiniciar != 'n' & reiniciar != 'N')
      {
        Console.Clear();
        Console.WriteLine("Opção inválida! Tente novamente.");
        goto pergunta;
      } else if (reiniciar == 's' | reiniciar == 'S')
      {
        goto inicio;
      } else
      {
        Console.WriteLine("Programa finalizado!");
      }
    }
  }
}
