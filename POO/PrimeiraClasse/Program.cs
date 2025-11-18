// // //Imports das classes extrernas
// // using System.Runtime.InteropServices;
using PrimeiraClasse;

// // string nome = "Júlia Maurício";

// // //Cria um objeto do tipo Hello
// // Hello cumprimento = new Hello();

// // cumprimento.TextoHello = "Olá usuário";
// // cumprimento.SaldarUsuario();
// // cumprimento.SaldarComNome("Júlia Maurício");

// // Carro c1 = new Carro();
// // c1.marca = "lamborghini";
// // c1.modelo = "Urus";
// // c1.cor = "Preto";
// // c1.qtdPortas = 4;
// // c1.qtdRodas = 4;
// // c1.Ligar ();
// // c1.Acelerar ();
// // c1.Frear ();
// // c1.Desligar();

// // Console.WriteLine($"Carro {c1.marca}");
// // Console.WriteLine($"modelo {c1.marca}");
// // Console.WriteLine($"cor {c1.marca}");
// // Console.WriteLine($"quantidade de portas: {c1.qtdPortas}");

// // Carro c2 = new Carro();
// // c2.marca = "Chevrolet";
// // c2.modelo = "Camaro";
// // c2.cor = "Amarelo";
// // c2.qtdPortas = 2;
// // c2.qtdRodas = 4;

// // Console.WriteLine($"Ligando o {c2.modelo}");
// // Console.WriteLine($"Acelerando {c2.modelo}");
// // Console.WriteLine($"Freando o {c2.modelo}");
// // Console.WriteLine($"Desligando o {c2.modelo}");

// // Console.WriteLine();
// // Console.WriteLine($"Caracteristicas:");
// // Console.WriteLine();



// using PrimeiraClasse;

// Moto m1 = new Moto();

// m1.Marca = "Honda";
// m1.Modelo = "Hornet 750";
// m1.Cor = "Branca";
// m1.qtRodas = 2;
// m1.Ligar();
// m1.Desligar();
// m1.Acelerar();
// m1.Freiar();

// Moto m2 = new Moto();

// m2.Marca = "BMW";
// m2.Modelo = "F 900 GS Adventure";
// m2.Cor = "Preta";
// m2.qtRodas = 2;
// m2.Ligar();
// m2.Desligar();
// m2.Acelerar();
// m2.Freiar();



// System.Console.WriteLine($"ligando o {m2.Modelo}");
// System.Console.WriteLine($"acelerando o {m2.Modelo}");
// System.Console.WriteLine($"freiando o {m2.Modelo}");
// System.Console.WriteLine($"desligando o {m2.Modelo}");
// System.Console.WriteLine();
// System.Console.WriteLine("-------------- Caracteristicas: -----------");
// System.Console.WriteLine();

// System.Console.WriteLine($"---------------{m1.Marca}---------------");

// System.Console.WriteLine($"Moto: {m1.Marca}");
// System.Console.WriteLine($"Modelo: {m1.Modelo}");
// System.Console.WriteLine($"Cor: {m1.Cor}");
// System.Console.WriteLine($"Quantidade de Rodas: {m1.qtRodas}");

// System.Console.WriteLine();
// System.Console.WriteLine("---");
// System.Console.WriteLine();

// System.Console.WriteLine($"---------------{m2.Marca}---------------");

// System.Console.WriteLine($"Moto: {m2.Marca}");
// System.Console.WriteLine($"Modelo: {m2.Modelo}");
// System.Console.WriteLine($"Cor {m2.Cor}");
// System.Console.WriteLine($"Quantidade de Rodas: {m2.qtRodas}");



// System.Console.WriteLine("-------------- Caracteristicas: -----------");

// Garrafa gf= new Garrafa();

// gf.modelo = "Plástico";
// gf.marca = "Bonafonty";
// gf.tampa = "Tampa de rosca";
// gf.cor = "Transparente";
// gf.qntA = "500ml";
// gf.Abrir();
// gf.Encher();
// gf.Fechar();
// gf.Esvaziar();

// Console.WriteLine($"Garrafa {gf.marca}");
// Console.WriteLine($"Abrir {gf.marca}");
// Console.WriteLine($"Encher {gf.marca}");
// Console.WriteLine($"Fechar {gf.marca}");
// Console.WriteLine($"Esvaziar {gf.marca}");
// Console.WriteLine();
// Console.WriteLine("-------------- Caracteristicas: -----------");
// Console.WriteLine();

// Console.WriteLine($"---------------{gf.marca}---------------");


// Console.WriteLine($"Garrafa: {gf.marca}");
// Console.WriteLine($"Modelo: {gf.modelo}");
// Console.WriteLine($"Cor: {gf.cor}");
// Console.WriteLine($"Quantidade de água: {gf.qntA}");
// Console.WriteLine($"Tipo de tampa: {gf.tampa}");

Garrafa g1 = new Garrafa();

Console.WriteLine("--GARRAFA--");

Console.WriteLine("Digite a quantidade máxima da sua garrafa: ");
g1.qntA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a marca da garrafa: ");
g1.marca = Console.ReadLine();

Console.WriteLine("Digite o modelo da garrafa: ");
g1.modelo = Console.ReadLine();

Console.WriteLine("Digite a cor da garrafa: ");
g1.cor = Console.ReadLine();

g1.Esvaziar();
g1.Encher();
g1.Abrir();
g1.Fechar();
