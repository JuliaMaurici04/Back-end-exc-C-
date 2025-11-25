using Encapsulamento;

float dinheiro = -200;

ContaBancaria contaEdu = new ContaBancaria();
ContaBancaria contaMaria = new ContaBancaria(dinheiro);

// System.Console.WriteLine($"Saldo da Conta {contaEdu.Saldo}");
contaEdu.Depositar(dinheiro);

// contaEdu.Saldo = dinheiro;
Console.WriteLine($"Saldo da Conta R${contaEdu.GetSaldo()}");

Console.WriteLine($"Saldo da Conta R${contaMaria.GetSaldo()}");