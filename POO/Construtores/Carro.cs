using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Carro
    {
        public string Modelo;
        public string Marca;
        public int Ano;

        public Carro(string m, string ma, int a)
        {
            Modelo = m;
            Marca = ma;
            Ano = a;
            Console.WriteLine("Objeto Carro Criado com parâmetros!");
        }
          public void ExibirDados()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
        }
       
    }
    
}