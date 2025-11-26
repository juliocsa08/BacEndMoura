using System.Data;
using System.Reflection;
using Exercicio02;
// List<Fatura> listafatura = new List<Fatura>();
// List<Relatorio> listaRelatorio = new List<Relatorio>();
// List<Contrato> listaContrato = new List<Contrato>();
List<IImprimir> Documentos = new List<IImprimir>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"====== Menu de opções ======
    
    1) Cadastrar Fatura
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) Listas Faturas
    5) Listar Relatórios
    6) Listar Contratos
    0) Sair");

    opcao = int.Parse(Console.ReadLine());

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
            ListarRelatorios();
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

    Console.WriteLine($"Pressione <<Enter>> para continuar");
    Console.ReadLine();

} while (opcao != 0);



void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do cliente devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura");
    float Valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Dias de atraso da fatura");
    int QtdDiasAtraso = int.Parse(Console.ReadLine());
    
    Fatura fat = new Fatura(dev, empresa, Valor, QtdDiasAtraso);
    Documentos.Add(fat);
}

void CadastrarRelatorios()
{
    
    Console.WriteLine($"Digite o nome do responsável");
    string NomeResponsavel = Console.ReadLine();

    Console.WriteLine($"Digite o texto do relatorio");
    string TextoRelatorio = Console.ReadLine();

    Relatorio Rel = new Relatorio(NomeResponsavel, TextoRelatorio);
    Documentos.Add(Rel);

}

void CadastrarContratos()
{
    Console.WriteLine($"Digite o nome do contrato");
    string Nome = Console.ReadLine();

    Console.WriteLine($"Digite a clausula do contrato");
    string TextoClausulas = Console.ReadLine();
    
    Contrato Con = new Contrato(Nome, TextoClausulas);
    Documentos.Add(Con);
    
}

void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in Documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarRelatorios()
{
    Console.WriteLine($"Listando Relatórios:");
    foreach (var item in Documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
    
}

void ListarContratos()
{
    Console.WriteLine($"Listando Contratos:");
    foreach (var item in Documentos)
    {
        
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
    
}




















// Fatura fatJV = new Fatura();
// Documentos.Add(fatJV);

// Fatura Ale = new Fatura();
// Documentos.Add(Ale);



// Relatorio relJV = new Relatorio();
// Documentos.Add(relJV);

// Relatorio Alex = new Relatorio();
// Documentos.Add(Alex);


// Contrato conJV = new Contrato();
// Documentos.Add(conJV);

// Contrato Edu = new Contrato();
// Documentos.Add(Edu);


// // fatRafa.Imprimir();
// // relRafa.Imprimir();
// // conRafa.Imprimir();


// //Listar os Dados 
// // for(int i = 0; i < listafatura.Count; i++)
// // {
// //     listafatura[i].Imprimir();
// // }
// Console.WriteLine($"FATURAS");
// foreach (var fat in Documentos)
// {
//     if (fat is Fatura)
//     {
//         fat.Imprimir();
//     }

// }

// Console.WriteLine($"");

// Console.WriteLine($"RELATÓRIOS");
// foreach (var rel in Documentos)
// {
//     if (rel is Relatorio)
//     {
//         rel.Imprimir();
//     }

// }

// Console.WriteLine($"");

// Console.WriteLine($"CONTRATOS");
// foreach (var con in Documentos)
// {
//     if (con is Contrato)
//     {
//         con.Imprimir();
//     }

//