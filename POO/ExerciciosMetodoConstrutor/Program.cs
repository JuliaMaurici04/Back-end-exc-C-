﻿using ExerciciosMetodosContrutor;

// -- Carro -- 

Carro c = new Carro(2012, "Civic G10", "Honda");

System.Console.WriteLine($"Modelo: {c.Modelo} || Marca: {c.Marca} || Ano: {c.Ano}");

System.Console.WriteLine();

// -- Aluno -- 

Aluno an1 = new Aluno(10, "Eduardo");

System.Console.WriteLine($"Aluno: {an1.Nome} || Nota: {an1.Nota}");

System.Console.WriteLine();

// -- Produto -- 

Produto p = new Produto(35, 24.99, "Mouse");

System.Console.WriteLine($"Nome: {p.Nome} || Estoque: {p.Estoque} || Preço: R${p.Preco} ");

System.Console.WriteLine();

// -- ContaBancaria --

ContaBancaria cb1 = new ContaBancaria(1000.99, "Eduardo");

System.Console.WriteLine($"Titular: {cb1.Titular} || Saldo: R${cb1.Saldo}"); // contrutor 1
System.Console.WriteLine();

ContaBancaria cb2 = new ContaBancaria("Carlos");

System.Console.WriteLine($"Titular: {cb2.Titular} || Saldo: R${cb2.Saldo}"); // contrutor 2

System.Console.WriteLine();

// -- Retângulo -- 

Retângulo r = new Retângulo(0, 0, 0);

System.Console.WriteLine("digite o tamanho do primeiro lado");
r.Lado1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("digite o tamanho do segundo lado");
r.Lado2 = int.Parse(Console.ReadLine());

r.AreaR(r.Lado1, r.Lado2);

//-- Aluno Média --

AlunoMédia am1 = new AlunoMédia(6, 7, 8);

System.Console.WriteLine("digaite o seu nome");
am1.Nome = Console.ReadLine();
am1.Média();
System.Console.WriteLine();

AlunoMédia am2 = new AlunoMédia();

System.Console.WriteLine("digaite o seu nome");
am2.Nome = Console.ReadLine();
am2.Média();
System.Console.WriteLine();
