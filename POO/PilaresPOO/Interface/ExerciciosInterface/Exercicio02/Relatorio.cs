using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        internal void Imprimir()
        {
            Console.WriteLine("Imprimindo o relatório...");
        }
    }
}