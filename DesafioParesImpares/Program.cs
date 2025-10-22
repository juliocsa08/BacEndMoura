int par = 0;
int impar = 1;

Console.WriteLine($"Olá, digite um valor impar ou par:c");

for (int i = 1; i < 15; i += 2)
{
    Console.WriteLine($"Valor do i: {i}");
    impar = impar + 2;
}


for (int t = 0; t < 16; t += 2)
{
    Console.WriteLine($"Valor do t: {t}");
    par = par + 2;
}
