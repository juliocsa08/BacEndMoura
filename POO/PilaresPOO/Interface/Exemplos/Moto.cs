using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Moto : IMotor
    { 
        
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

         public Moto (string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }


         public void ExibirInfo()
        {
            Console.WriteLine($@"Informações do Veiculo:
            Marca: {Marca}
            Modelo: {Modelo}
            Cor: {Cor}
            Ano: {Ano}
            ");
        }

        public void Acelerar()
        {
         Console.WriteLine("A Moto está acelerando.... Rammmm Dam Dam!");
        }

        public void Freiar()
        {
          Console.WriteLine("A Moto está freiando.... Irrrrrrrrrrrr!");
        }
    }
}