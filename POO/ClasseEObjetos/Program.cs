//using ClasseEObjetos;

//Garrafa Tupperware = new Garrafa();
//Tupperware.Cor = "Vermelho";
//Tupperware.Capacidade = 500;
//Tupperware.Tamanho = 27;
//Tupperware.Formato = "Arredondada";
//Tupperware.Abrir();
//Tupperware.Beber();

//Garrafa Stanley = new Garrafa();
//Stanley.Cor = "Preta";
//Stanley.Capacidade = 500;
//Stanley.Formato = "Cilíndrico";
///Stanley.Tamanho = 20;
// Console.Write($"Abrindo a garrafa Stanley: ");
//Stanley.Abrir();

//Console.Write($"Bebendo água da garrafa: ");
///Stanley.Beber();
///

//using ClasseEObjetos;
///Console.Clear();
//Console.WriteLine("==Agência Bancária==");
//Console.WriteLine("");

//AgenciaBancaria contaDoJoao = new AgenciaBancaria();

//contaDoJoao.Titular = "João Silva";
///contaDoJoao.Saldo = 1000.98f;
//contaDoJoao.Depositar(-500); 

//contaDoJoao.Sacar(2000);

using System;
{
Produto panela = new Produto();
panela.nome = "Panela de Pressao Tramontina";
panela.preco = 200;

Console.WriteLine($"{panela.nome} custa {panela.preco}");

    panela.AplicarDesconto(20);
}