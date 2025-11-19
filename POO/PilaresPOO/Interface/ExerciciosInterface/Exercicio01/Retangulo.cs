using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio01;

namespace Exercicio1
{
    public class Retangulo : IForma
{
    public float Largura;
    public float Altura ;
    public Retangulo (float largura, float altura)
    {
        Largura = largura;
        Altura = altura;
    }


        public void CalcularArea()
        {
            float area = Largura * Altura;
            Console.WriteLine($"Área do Retângulo = {area}");
        }
    }
}