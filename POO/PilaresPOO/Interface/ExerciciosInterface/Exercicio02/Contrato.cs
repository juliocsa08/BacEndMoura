using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Contrato : IImprimivel
    {

     public string Nome;
     
     public string TextoClausulas;
        public void Imprimir()
        {
        Console.WriteLine("Imprimindo o contrato...");
    }
}

}

