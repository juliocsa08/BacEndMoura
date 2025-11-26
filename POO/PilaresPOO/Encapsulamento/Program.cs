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
 

        
    Carro meuCarro = new Carro();
    
    meuCarro.DefinirMarca("Toyota");
    meuCarro.DefinirModelo("Corolla");

    meuCarro.Acelerar(50);   
    meuCarro.Acelerar(30);  
    meuCarro.Frear(20);      
    meuCarro.Frear(70);      

        Console.WriteLine();

    Console.WriteLine("Marca: " + meuCarro.ObterMarca());
    Console.WriteLine("Modelo: " + meuCarro.ObterModelo());
    Console.WriteLine("Velocidade Atual: " + meuCarro.ObterVelocidade() + " km/h");
    
