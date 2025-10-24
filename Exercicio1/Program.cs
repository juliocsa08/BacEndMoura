double NP, t, p;
double i = 0;

Console.Write("Informe o salário recebido: ");
double salario = Convert.ToDouble(Console.ReadLine());

// Solicita o total gasto
Console.Write("Informe o total gasto: ");
double gasto = Convert.ToDouble(Console.ReadLine());

// Verifica se os gastos estão dentro do orçamento
if (gasto <= salario)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else
{
    Console.WriteLine("Orçamento estourado");
}