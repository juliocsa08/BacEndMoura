int quantidadeNumeros, numero;
int contador = 0;

Console.WriteLine("Quantos números você deseja digitar?");
quantidadeNumeros = int.Parse(Console.ReadLine());

while (contador < quantidadeNumeros)
{
    Console.WriteLine("Digite um número:");
    numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0) // Verifica se o número é par
    {
        Console.WriteLine($"O número {numero} é PAR.");
    }

    contador++;
}

Console.WriteLine("Fim do programa.");