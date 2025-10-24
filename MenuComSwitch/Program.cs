//-------------------------------------------//
//              Bem-vindo usuario            //
//-------------------------------------------//
int opcao = -1;

do
{
    Console.WriteLine($"-------------------------------");
    Console.WriteLine($"         Bem-vindo             ");
    Console.WriteLine($"            ao                 ");
    Console.WriteLine($"       Jacareca food           ");
    Console.WriteLine($"-------------------------------");

    Console.WriteLine($"Escolha uma opção abaixo");
    Console.WriteLine();
    Console.WriteLine($"   1) Hot Holl.....................R$29,90");
    Console.WriteLine($"   2) Temaki.......................R$30,00");
    Console.WriteLine($"   3) Sashimi......................R$67,20");
    Console.WriteLine($"   4) Yakisoba.....................R$35,95");
    Console.WriteLine($"   5) Guioza.......................R$49,00");
    Console.WriteLine($"   6) Shimeji......................R$50,90");
    Console.WriteLine($"   7) Sair");
    Console.WriteLine($"Opção:");
    opcao = int.Parse(Console.ReadLine());





    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine($"Digite <enter> para continuar...");
            break;
        case 1:
            Console.WriteLine($"Você escolheu Hot Holl, o valor é R$29,90 Vamos preparar seu pedido!🙃");
            break;
        case 2:
            Console.WriteLine($"Você escolheu Temaki, o valor é R$30,00  Vamos preparar seu pedido!🙃");
            break;
        case 3:
            Console.WriteLine($"Você escolheu Sashimi, o valor é R$67,20 Vamos preparar seu pedido!🙃");
            break;
        case 4:
            Console.WriteLine($"Você escolheu Yakisoba, o valor é R$35,95 Vamos preparar seu pedido!🙃");
            break;
        case 5:
            Console.WriteLine($"Você escolheu Guioza, o valor é R$49,00 Vamos preparar seu pedido!🙃");
            break;
        case 6:
            Console.WriteLine($"Você escolheu Shimeji, o valor é R$50,90 Vamos preparar seu pedido!🙃");
            break;
        case 7:
            Console.WriteLine($"Saindo...");
            break;
        default:
            Console.WriteLine($"Opção inválida!");
            break;
    }
    Console.WriteLine($"Saindo...");
    Console.WriteLine($"Digite <enter> para continuar...");
} while (opcao != 0);
    
    void HotHool()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Hot Holl com carinho");
}

void Temaki()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Temaki com carinho");
}

void Sashimi()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Sashimi com carinho");
}

void Yakisoba()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Yakisoba com carinho");
}

void Guioza()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Guioza com carinho");
}

void Shimeji()
{
    Console.WriteLine($"Boa escolha, vamos preparar seu Shimeji com carinho");
}