string Exercicio3()
{
    Console.Write("Informe o primeiro lado do triângulo: ");
    double lado1 = double.Parse(Console.ReadLine());
    Console.Write("Informe o segundo lado do triângulo: ");
    double lado2 = double.Parse(Console.ReadLine());
    Console.Write("Informe o terceiro lado do triângulo: ");
    double lado3 = double.Parse(Console.ReadLine());

    if (lado1 == lado2 && lado2 == lado3)
        return "Triângulo Equilátero";
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        return "Triângulo Isósceles";
    else
        return "Triângulo Escaleno";
}