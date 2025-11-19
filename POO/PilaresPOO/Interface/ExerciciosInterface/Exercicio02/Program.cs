using Exercicio02;

// // criar uma lista para faturas
 

// // Cria um objeto de casa classe e adiciona nas listas
// Fatura fatJU = new Fatura();
// documentos.Add(fatJU);
// Fatura fatJU = new Fatura();
// documentos.Add(fatJU);

// Relatorio relJU = new Relatorio();
// documentos.Add(relJU);
// Relatorio reJU = new Relatorio();
// documentos.Add(reJU);

// Contrato contJU = new Contrato();
// documentos.Add(contJU);
// Contrato contJU = new Contrato();
// documentos.Add(contJU);


// Console.WriteLine($"Faturas: ");
// foreach (var fatura in documentos)
// {
//     if (fatura is Fatura)
//     {
//         fatura.Imprimir();
//     }
// }

// Console.WriteLine($"Contraros: ");
// foreach (var contrato in documentos)
// {
//     if (contrato is Contrato)
//     {
//         contrato.Imprimir();
//     }
// }

// Console.WriteLine($"Relatorios: ");
// foreach (var relatorio in documentos)
// {
//     if (relatorio is Relatorio)
//     {
//         relatorio.Imprimir();
//     }
// }
// criar uma lista para faturas
List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"Menu de Opções
    1) Cadastrar Fatura);
    2) Cadastrar Relatorio
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatorios
    6) Listar Contratos
    0) Sair
    Escolha a opção:
    ");
    opcao = int.Parse(Console.ReadLine());

    //criar um swith case para as opções do menu
    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;
        case 2:
            CadastrarRelatorios();
            break;
        case 3:
           CadastrarContratos();
            break;
        case 4:
           ListarFaturas();
            break;
        case 5:
            ListarRelatorio();
            break;
        case 6:
           ListarContratos();
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
        Console.WriteLine($"Opção Inválida");
            break;
    }


    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();


} while (opcao != 0);

void CadastrarFaturas()
{
 Console.WriteLine($"Digite o nome do cliente devedor");
 string dev = Console.ReadLine();
 Console.WriteLine($"Digite o nome da empresa");
 string empresa = Console.ReadLine();
 Console.WriteLine($"Digite o valor da fatura");
 float valor = float.Parse(Console.ReadLine());
 Console.WriteLine($"Digite os dias de atraso da fatura");
 int qtdDiasAtrado =int.Parse(Console.ReadLine());

Fatura fat = new Fatura(dev, empresa, valor, qtdDiasAtrado);
documentos.Add(fat);
}
void CadastrarContratos()
{
    


}
void CadastrarRelatorios()
{
    


}
void ListarContratos()
{
    


}
void ListarFaturas()
{
  Console.WriteLine($"Listando Faturas:");
  foreach(Fatura item in documentos)
    {
     if(item is Fatura)

        {
           item.Imprimir(); 

        }   


    }
    


}
void ListarRelatorio()
{
    


}






