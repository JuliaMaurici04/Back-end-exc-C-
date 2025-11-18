using Exercicio02;

// List<Fatura> documentos = new List<Fatura>();
// List<Relatorio> documentos2 = new List<Relatorio>();
// List<Contrato> documentos3 = new List<Contrato>();

// // Fatura fatZe = new Fatura();
// // fatZe.Dono = "Zé da Esquina";
// // Fatura fatMaria = new Fatura();
// // fatMaria.Dono = "Maria Eduarda";

// Fatura fatZe = new Fatura();
// fatZe.Devedor = "Zé da Esquina";
// documentos.Add(fatZe);

// Relatorio relHenrique = new Relatorio();
// relHenrique.Nome = "Henrique Nascimento";
// documentos2.Add(relHenrique);

// Contrato MariaContrato = new Contrato();
// MariaContrato.Nome = "Henrique Nascimento";
// documentos3.Add(MariaContrato);

// // // Relatorio relaZe = new Relatorio();
// // // relaZe.Dono = "Zé da Esquina";
// // // Relatorio relaMaria = new Relatorio();
// // // relaMaria.Dono = "Maria Eduarda";
// // // Relatorio relaEdu = new Relatorio();
// // // relaEdu.Dono = "Eduardo Pereira";
// // // Relatorio relaHenrique = new Relatorio();
// // // relaHenrique.Dono = "Henrique Nascimento";
// // // Relatorio relaMarcos = new Relatorio();
// // // relaMarcos.Dono = "Marcos Vinícius";
// // // Relatorio relaFrancisco = new Relatorio();
// // // relaFrancisco.Dono = "Francisco Hugo";
// // // Relatorio relaDavi = new Relatorio();
// // // relaDavi.Dono = "Davi Muniz";
// // // Relatorio relaLucas = new Relatorio();
// // // relaLucas.Dono = "Lucas Marinho";
// // // Relatorio relaJoao = new Relatorio();
// // // fatJoao.Dono = "João";

// // // Contrato conZe = new Contrato();
// // // conZe.Dono = "Zé da Esquina";
// // // Contrato conMaria = new Contrato();
// // // conMaria.Dono = "Maria Eduarda";
// // // Contrato conEdu = new Contrato();
// // // conEdu.Dono = "Eduardo Pereira";
// // // Contrato conHenrique = new Contrato();
// // // conHenrique.Dono = "Henrique Nascimento";
// // // Contrato conMarcos = new Contrato();
// // // conMarcos.Dono = "Marcos Vinícius";
// // // Contrato conFrancisco = new Contrato();
// // // conFrancisco.Dono = "Francisco Hugo";
// // // Contrato conDavi = new Contrato();
// // // conDavi.Dono = "Davi Muniz";
// // // Contrato conLucas = new Contrato();
// // // conLucas.Dono = "Lucas Marinho";
// // // Contrato conJoao = new Contrato();
// // // fatJoao.Dono = "João";

// // listaDeFaturas.Add(fatDavi);
// // listaDeFaturas.Add(fatEdu);
// // listaDeFaturas.Add(fatFrancisco);
// // listaDeFaturas.Add(fatHenrique);
// // listaDeFaturas.Add(fatJoao);
// // listaDeFaturas.Add(fatMarcos);
// // listaDeFaturas.Add(fatLucas);
// // listaDeFaturas.Add(fatZe);
// // listaDeFaturas.Add(fatMaria);

// // listaDeRelatorios.Add(relaDavi);
// // listaDeRelatorios.Add(relaEdu);
// // listaDeRelatorios.Add(relaFrancisco);
// // listaDeRelatorios.Add(relaHenrique);
// // listaDeRelatorios.Add(relaJoao);
// // listaDeRelatorios.Add(relaMarcos);
// // listaDeRelatorios.Add(relaLucas);
// // listaDeRelatorios.Add(relaZe);
// // listaDeRelatorios.Add(relaMaria);

// // listaDeContratos.Add(conDavi);
// // listaDeContratos.Add(conEdu);
// // listaDeContratos.Add(conFrancisco);
// // listaDeContratos.Add(conHenrique);
// // listaDeContratos.Add(conJoao);
// // listaDeContratos.Add(conMarcos);
// // listaDeContratos.Add(conLucas);
// // listaDeContratos.Add(conZe);
// // listaDeContratos.Add(conMaria);

// foreach (var item in documentos)
// {
//     item.Imprimir();
// }

// foreach (var item in documentos2)
// {
//     item.Imprimir();
// }

// foreach (var item in documentos3)
// {
//     item.Imprimir();
// }

// Relatorio rl = new Relatorio();
// rl.Imprimir();
// Contrato c1 = new Contrato();
// c1.Imprimir();
// Fatura ft = new Fatura();
// ft.Imprimir();

List<IImprimivel> documentos = new List<IImprimivel>();

// Fatura fatEdu = new Fatura("Eduardo", "Izabel Dark Lab", 50, 1);
// fatEdu.Imprimir();

int opcao;
do
{
    Console.Clear();
    Console.WriteLine($"Menu de Opcões");
    Console.WriteLine($@"
1) Cadastra Fatura
2) Cadastra Relatório
3) Cadastra Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Faturas
0) Sair
Escolha a opção");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar Faturas");
            CadastraFatura();
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatórios");
            CadastrarRelatorio();
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contratos");
            CadastrarContrato();
            break;
        case 4:
            Console.WriteLine($"Listar Faturas");
            ListarFatura();
            break;
        case 6:
            Console.WriteLine($"Listar Relatórios");
            ListarRelatorio();
            break;
        case 0:
            Console.WriteLine($"Listar Contratos");
            ListarContrato();
            break;
        default:
            Console.WriteLine($"Sair");
            break;
    }

    Console.ReadLine();//para o console para dar tempo de ver as mensagens do programa
    Console.WriteLine($"DIgite <Enter> para continuar ...");


} while (opcao != 0);

// Funcões Auxiliares

void CadastraFatura()
{
    Console.WriteLine($"Digite o nome do devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome do credor");
    string cred = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura");
    float Valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Quantos dias a fatura esta em atraso?");
    int DiasAtraso = int.Parse(Console.ReadLine());

    // cria o objeto da fatura
    Fatura fat = new Fatura(dev, cred, Valor, DiasAtraso);
    // cadastrar a fatura na lista
    documentos.Add(fat);
}


//Contrato
void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do contratante:");
    string contratante = Console.ReadLine();

    Console.WriteLine($"Digite o nome da pessoa contratada");
    string contratada = Console.ReadLine();

    Console.WriteLine($"Quais sao as clausulas do contrato?");
    string txtClausulas = Console.ReadLine();

    Contrato c = new Contrato(contratante, contratada, txtClausulas);
    documentos.Add(c);

}

//Relatorio
void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o nome do Responsavel:");
    string responsavel = Console.ReadLine();

    Console.WriteLine($"Digite o nome da pessoa contratada");
    string txtRelatorio = Console.ReadLine();

    Console.WriteLine($"Quais sao as clausulas do contrato?");
    string txtClausulas = Console.ReadLine();

    Relatorio r = new Relatorio(responsavel, txtRelatorio);

    documentos.Add(r);

}

//Listar
void ListarFatura()
{
    foreach (var item in documentos)
    {
        if(item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarContrato()
{
    foreach (var item in documentos)
    {
        if(item is Contrato)
        {
            item.Imprimir();
        }
    }
}
void ListarRelatorio()
{
    foreach (var item in documentos)
    {
        if(item is Relatorio)
        {
            item.Imprimir();
        }
    }
}
