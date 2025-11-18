﻿using Heranca;
Console.Clear();

// Veiculo fusca = new Veiculo();
// fusca.Ano = 1979;
// fusca.Modelo = "Fusca 79";
// fusca.Marca = "Wolkswagem";

// Carro corola = new Carro();
// corola.Ano = 2005;
// corola.Modelo = "Corola Cross";
// corola.Marca = "Toyota";

// Console.WriteLine($"Carro: {fusca.Modelo}");
// fusca.Acelerar();

// Console.WriteLine();
// Console.WriteLine($"Carro: {corola.Modelo}");
// corola.Acelerar();


// Cachorro meuCachorro = new Cachorro();
// Gato meuGato = new Gato();

// meuCachorro.FazerSom();  //saida: Auau
// meuGato.FazerSom();  //saida: miau

Funcionario f1 = new Funcionario();
f1.Nome = "Mangile";
f1.SalarioBase = 5000;

Gerente g1 = new Gerente();
g1.Nome = "Matheus";
g1.SalarioBase = 10000;
g1.Bonus = 2500;

System.Console.WriteLine($"Funcionario: {f1.Nome}, Salario: {f1.CalcularSalario()}");
System.Console.WriteLine($"Gerente: {g1.Nome}, Salario: {g1.CalcularSalario()}");
