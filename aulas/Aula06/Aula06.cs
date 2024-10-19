using System;

namespace Aula06
{
  class Program
  {
    static void Main()
    {
      double valor_compra = 5.5;
      double valor_venda;
      double lucro = 0.1;
      string produto = "Pastel";

      valor_venda = valor_compra + (valor_compra * lucro);

      Console.WriteLine("Produto........: {0, 11}", produto);
      Console.WriteLine("Val. compra....: {0, 11:c}", valor_compra);
      Console.WriteLine("Lucro..........: {0, 11:p}", lucro);
      Console.WriteLine("Val. Venda.....: {0, 11:c}", valor_venda);
    }
  }
}
