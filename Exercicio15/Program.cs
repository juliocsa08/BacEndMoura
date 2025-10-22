
float n1, n2, n3, n4;


Console.WriteLine("Digite a primeira nota:");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota:");
n4 = float.Parse(Console.ReadLine());


float media = (n1 + n2 + n3 + n4) / 4;

if (media >= 7.0)
{
    Console.WriteLine("APROVADO");
}
else if (media >= 5.0)
{
    Console.WriteLine("RECUPERAÇÃO");
}
else
{
    Console.WriteLine("REPROVADO");
}
