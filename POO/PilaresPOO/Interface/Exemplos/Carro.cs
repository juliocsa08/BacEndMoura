using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Carro : IMotor
    {
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($@"Informações do Carro:v 
            Marca: {Marca}
            Modelo: {Modelo}
            Cor: {Cor}
            Ano: {Ano}
            ");
        }


        public void Acelerar()
        {
            Console.WriteLine("O carro está acelerando.... Vruumm Vrumm!");
        }

        public void Freiar()
        {
            Console.WriteLine("O carro está freiando.... Irrrrrrrrrrrr!");
        }
    }
}