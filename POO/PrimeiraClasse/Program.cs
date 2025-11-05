using PrimeiraClasse;

Console.WriteLine($"==== PROGRAMA PRIMEIRA CLASSE ====");




//Carro Mclaren = new Carro();
//Mclaren.marca = "Mclaren";
//Mclaren.cor = "Laranja";
//Mclaren.Modelo = "750s";
//Mclaren.potencia = 750;


//Console.WriteLine($"ligando a  {Mclaren.marca} {Mclaren.cor}");
//Mclaren.Ligar();
//Console.WriteLine($"Acelerando a {Mclaren.marca}  de {Mclaren.potencia} cv");
//Mclaren.Acelerar(); 



//Pessoa julio = new Pessoa();
//julio.Nome = "julio ";
//julio.Idade = 17;
//julio.Altura = 178;

///julio.Falar();
//julio.Dormir();


// Garrafa Tuperware = new Garrafa();
// Tuperware.Cor = "Azul";
// Tuperware.Capacidade = 500; //ml
// Tuperware.Tamanho = 27;
// Tuperware.Formato = "arredondado";

// Tuperware.Beber ();
// Tuperware.Abrir();


Console.Clear();
Pessoa anne = new Pessoa();
anne.Nome = "Anne";
anne.Altura = 166;
anne.Idade = 17;

Console.WriteLine($"{anne.Nome} tem {anne.Altura} cm de altura.");
anne.Envelhecer(10);
Console.WriteLine($"{anne.Nome} agora tem {anne.Idade} anos.");