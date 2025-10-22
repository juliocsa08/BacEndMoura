//pedir para o usuario digitar o nome, sobrenom, idade, saldo bancario e quanto ele investiu esse ano

//camel case - letra maiúscula a patir da segunda palavra
String nome;
string SobrenomeDoFulano;
int idade;
float Saldo;
float investimentos;
//pasca case - primeira letra de cada palavra maiuscula
Console.WriteLine("Olá qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("qual é o seu sobrenome?");
SobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("qual é a sua idade?");
idade = int.Parse(Console.ReadLine()); //converte o texto em int antes de jogar na variavel

Console.WriteLine("qual é o seu saldo bancário?");
Saldo = float.Parse(Console.ReadLine());  //converte o texto digitado no console em float

Console.WriteLine("quanto você investiu esse ano?");
investimentos = float.Parse(Console.ReadLine());


//receber o investmento do usuario

Console.Clear(); //limpar o console
Console.WriteLine($"Nome: {nome} {SobrenomeDoFulano}");
Console.WriteLine($"Idade do {nome} é {idade}");
Console.WriteLine($"Saldo bancário: {Saldo}");
Console.WriteLine($"Investiementos esse ano: {investimentos}");