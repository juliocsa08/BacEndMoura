using ExercicioPolimorfismo;

PagamentoPix compraPix = new PagamentoPix();
compraPix.ValorCompra = 15000;

float valorPagar = compraPix.CalcularTotal();
Console.WriteLine("Produto: smartphone");
Console.WriteLine("Preço: {compraPix.ValorCompra}");
Console.WriteLine("Pagamento com Desconto: {valorPagar}");

PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50;

Console.WriteLine("Produto: Caneca");
Console.WriteLine("Preço: {compraCartao.ValorCompra}");
Console.WriteLine("Forma de pagamento: Cartão");
Console.WriteLine("Pagamento com Acréscimo: {compraCartao.CalcularTotal()}");