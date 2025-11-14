// using Exemplos;
// Console.Clear();

// // Gato birobinha =  new Gato();
// // Cachorro toto = new Cachorro();

// Pessoa julio = new Pessoa();
// julio.Nome = "Julio Cesar";
// julio.Idade = 17;

// Console.WriteLine($"Nome: {julio.Nome}");
// Console.WriteLine($"Idade: {julio.Idade}");

// Console.WriteLine($"Som do {julio.Nome}");
// julio.FazerSom();
// Console.WriteLine($"{julio.Nome}");
// julio.Mover();

// Console.WriteLine($"{julio.Nome} foi dormir:");
// julio.Dormir();

 using Exemplos;
 Console.Clear();

Console.WriteLine($"==== CONTA CORRENTE: ====");
ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial: {cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo após depósito: {cc.Saldo}");
cc.Sacar(10.01);
Console.WriteLine($"Saldo após saque: {cc.Saldo}");

ContaPoupanca cp = new ContaPoupanca();


Console.WriteLine($"==== CONTA POUPANÇA: ====");
Console.WriteLine($"Saldo inicial: {cp.Saldo}");
ContaPoupanca contaPoupanca = new ContaPoupanca();
Console.WriteLine($"Saldo inicial: {cp.Saldo}");
cp.Depositar(0.5);
Console.WriteLine($"Saldo após depósito: {cp.Saldo}");
cp.Sacar(10.01);
Console.WriteLine($"Saldo após saque: {cp.Saldo}");
