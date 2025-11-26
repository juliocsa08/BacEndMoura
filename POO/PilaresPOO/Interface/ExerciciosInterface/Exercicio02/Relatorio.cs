using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Relatorio : IImprimir
    {
        public string NomeResponsavel;
        public string TextoRelatorio;

        public Relatorio(string NomeRelatorio, string Texto)
        {
            NomeResponsavel = NomeRelatorio;
            TextoRelatorio = Texto;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo Relatório...");
            Console.WriteLine($"");
            Console.WriteLine($"Nome do Responável: {NomeResponsavel}");
            Console.WriteLine($"Texto do relatório: {TextoRelatorio}");
        }
    }
}