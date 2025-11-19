using Exercicio1;

Console.Clear();
Console.WriteLine("=== EXERCÍCIO 1 - Formas ===");
Console.WriteLine();

Console.WriteLine($"Vamos calcular a área de um retângulo.");

Console.Write("Informe a largura do retângulo: ");
float largura = float.Parse(Console.ReadLine());
Console.Write("Informe a altura do retângulo: ");
float altura = float.Parse(Console.ReadLine());
Retangulo retangulo = new Retangulo(largura, altura);
Console.WriteLine();


    
Console.WriteLine($"Agora, vamos calcular a área de um círculo.");
Console.WriteLine("Informe o raio do círculo: ");
float raio = float.Parse(Console.ReadLine());
Circulo circulo = new Circulo();
circulo.Raio = raio;

Console.WriteLine();
retangulo.CalcularArea();
circulo.CalcularArea();
