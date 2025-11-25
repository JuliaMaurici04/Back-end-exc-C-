// using Encapsulamento;

// float dinheiro = 200;

// ContaBancaria contaEdu = new ContaBancaria();
// ContaBancaria contaMaria = new ContaBancaria(dinheiro);

// // System.Console.WriteLine($"Saldo da Conta {contaEdu.Saldo}");
// contaEdu.Depositar(dinheiro);
// contaMaria.Sacar(100);

// // contaEdu.Saldo = dinheiro;
// Console.WriteLine($"Saldo da Conta R${contaEdu.GetSaldo()}");

// Console.WriteLine($"Saldo da Conta R${contaMaria.GetSaldo()}");

using Encapsulamento;

Carro Fusca = new Carro();

Fusca.DefinirMarca("Volkswagen");
Fusca.DefinirModelo("Fusca 89");


Fusca.Acelera(100);
Fusca.Acelera(50);

Fusca.Frear(10);
Console.WriteLine($"Marca: {Fusca.ObterMarca()}");
Console.WriteLine($"Modelo: {Fusca.ObterModelo()}");
Console.WriteLine($"Velocidade Atual:{Fusca.ObterVelocidade()}");