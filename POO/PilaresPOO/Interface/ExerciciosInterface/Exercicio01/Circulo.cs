using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercicio01;

namespace Exercicio1;

  public class Circulo : IForma
{
    public float Raio ;

    public void CalcularArea()
    {
        float area = (float)Math.PI * Raio * Raio;
        Console.WriteLine($"Área do Círculo = {area}");
    }
    }


