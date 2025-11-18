// using ClassEObjetos;


// Garrafa gf = new Garrafa();

// Console.WriteLine("--GARRAFA--");

// System.Console.WriteLine("Digite seu nome");
// gf.Nome = Console.ReadLine();
// Console.ReadLine();

// Console.WriteLine("Digite a quantidade máxima da sua garrafa: ");
// gf.qntA = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite a marca da garrafa: ");
// gf.marca = Console.ReadLine();

// Console.WriteLine("Digite o modelo da garrafa: ");
// gf.modelo = Console.ReadLine();

// Console.WriteLine("Digite a cor da garrafa: ");
// gf.cor = Console.ReadLine();

// Console.WriteLine("Digite o tipo de tampa da garrafa: ");
// gf.tampa = Console.ReadLine();

// System.Console.WriteLine("-------------------------");


// gf.Abrir();
// gf.Encher();
// gf.Fechar();
// gf.Esvaziar();

// System.Console.WriteLine("-------------------------");

// Console.WriteLine($"Garrafa: {gf.marca}");
// Console.WriteLine($"Modelo: {gf.modelo}");
// Console.WriteLine($"Cor: {gf.cor}");
// Console.WriteLine($"Quantidade de água: {gf.qntA}");
// Console.WriteLine($"Tipo de tampa: {gf.tampa}");

// System.Console.WriteLine("-------------------------");

// // Console.WriteLine($"--------------- SEU NOME ---------------");

// using ClassEObjetos;

// Pessoa Julia = new Pessoa();
// Julia.Idade = 17;
// Julia.Envelhercer(17);

// Julia.Nome = "Julia Mauricio";
// Console.WriteLine($"{Julia.Nome} tem {Julia.Idade} anos");

// int novaIdade = Julia.Envelhercer(17);
// Console.WriteLine($" {Julia.Nome} tem {Julia.Idade} anos");


using ClassEObjetos;

Console.WriteLine($"-- ContaBancaria --");
Console.WriteLine($"Digite o nome  do titular da  --");
string nomeT = Console.ReadLine();

ContaBancaria conta = new ContaBancaria(nomeT);
Console.WriteLine($"Bem vindo, {conta.titular}");
Console.WriteLine($"Saldo inicial: R$ {conta.saldo:F2}");
Console.WriteLine();

int opcao = 0;
do
{
    Console.WriteLine($"\n Menu");
    Console.WriteLine($"1 - Depositar");
    Console.WriteLine($"2 - Sacar");
    Console.WriteLine($"0 - Sair");

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"");
            double Depósito = Convert.ToDouble(Console.ReadLine());
            conta.depositar(Depósito);
            break;

        case 2:
            Console.WriteLine($"Digite o valor de saque: R$ ");
            double saque = Convert.ToDouble(Console.ReadLine());
            conta.sacar(saque);
            break;

        case 0:
            Console.WriteLine($"Saindo.");
            break;

        default:
            Console.WriteLine($"Opcão inválida, escolhe uma das opcões acima.");
            break;
    }

} while (opcao != 0);
