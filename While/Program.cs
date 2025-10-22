int NP, t, p;
int i = 0;

Console.WriteLine("Insira um numero de repeticoes");
NP = int.Parse(Console.ReadLine());

while (i < NP)
{
    Console.WriteLine("Insira um numero");
    p = int.Parse(Console.ReadLine());

    Console.WriteLine("Insira o segundo numero");
    t = int.Parse(Console.ReadLine());

    if (p > t)
    {
        Console.WriteLine($"o numero {p} e maior que o {t}");
    }
    else
    {
        Console.WriteLine($"o numero {t} e maior que o {p}");
    }

Thread.Sleep(1500);

    i++;
}

Thread.Sleep(1500);

Console.WriteLine("Numero de repeticoes excedidas");