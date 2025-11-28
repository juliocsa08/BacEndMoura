using Encapsulamento;


// ContaBancaria contaJu = new ContaBancaria();
// ContaBancaria contamadu = new ContaBancaria(1500);
//  contaJu.Despositar(-100);
//  contaJu.Despositar(20);
//  contaJu.Sacar(-200);
//  contamadu.Sacar(100);
 

//  Console.WriteLine();
 

//  Console.WriteLine($"Saldo atual do Ju: R${contaJu.GetSaldo()}");
//  Console.WriteLine($"Saldo atual da madu: R${contamadu.GetSaldo()}");
 

   Carro carro = new Carro();

carro.DefinirMarca("Toyota");
carro.DefinirModelo("Corolla");

carro.Acelerar(30);
carro.Acelerar(20);
carro.Frear(10);
carro.Frear(50); 


Console.WriteLine($"Marca: {carro.ObterMarca()}");
Console.WriteLine($"Modelo:  {carro.ObterModelo()}");
Console.WriteLine($"Velocidade Atual:  {carro.ObterVelocidade()}km/h");