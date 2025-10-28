// Criar um menu da seguinte forma em loop que chame as funções:
//1. Cadastrar Cliente
//2. Depositar
//3. Sacar
//4. Transferir
//5. Listar Clientes
//o. Sair

using Microsoft.VisualBasic;

string[] nome = new string[3];
int opcao = -1;
int totalClientes = 0;
int[] dinheiro = new int[3];


//return;


do
{
    Console.WriteLine();
    Console.WriteLine($"========== SISTEMA BANCÁRIO SIMPLES ==========");
    Console.WriteLine();
    Console.WriteLine($"1. Cadastrar Cliente");
    Console.WriteLine($"2. Depositar");
    Console.WriteLine($"3. Sacar");
    Console.WriteLine($"4. Transferir");
    Console.WriteLine($"5. Listar Clientes");
    Console.WriteLine($"0. Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.Write($"Encerrando ...");
            Console.Write($"Pressione <Enter> para encerrar ...");
            Console.ReadLine();
            break;
        case 1:
            CadastrarClientes();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarClientes();
            break;

        default:
            Console.WriteLine($"Opção Inválida, pressione <Enter> para continuar ...");
            Console.ReadLine();
            break;
    }

} while (opcao != 0);

void CadastrarClientes()
{

    if (totalClientes >= 3)
    {
        Console.WriteLine($"Limite de ocupação atigindo");
        Console.WriteLine($"Pressione <Enter> para continuar");
        Console.ReadLine();
        return;
    }

    Console.WriteLine($"Digite o nome do Cliente: ");
    nome[totalClientes] = Console.ReadLine();
    dinheiro[totalClientes] = 0;
    totalClientes++;
    Console.WriteLine($"Cliente cadastrado com sucesso!!");
    Console.WriteLine($"Pressione <Enter> para continuar");

}

void ListarClientes()
{
    Console.Write($"=== Lista de Clientes ===");
    Console.WriteLine();

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nome[i]} saldo: R$ {dinheiro[i]:F2}");
        Console.WriteLine();
    }

    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();
}

void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    Console.WriteLine($"Valor para depósito: ");
    int valorDeposito = int.Parse(Console.ReadLine());
    dinheiro[idCliente] += valorDeposito;
    Console.WriteLine($"Depósito de R$ {valorDeposito} realizado!");

    Console.ReadLine();//para o sistema e esperar o usuário dar um <Enter>

}
void Transferir()
{

    Console.WriteLine($"== Transferência ==");
    Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {//não existe
        return;
    }
    Console.WriteLine($"Conta de destino: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {//não existe
        return;
    }
    Console.WriteLine($"Valor para transferir: ");
    int valor = int.Parse(Console.ReadLine());
    if (dinheiro[idClienteOrigem] >= valor)
    {
        dinheiro[idClienteOrigem] -= valor;
        dinheiro[idClienteDestino] += valor;
        Console.WriteLine($"Saldo transferido com sucesso!");

    }
    else
    {
        Console.WriteLine($"Saldo insuficiente");
    }
    
    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();//para o sistema e esperar o usuário dar um <Enter>
}
void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    Console.WriteLine($"Qual valor você gostaria de sacar?: ");
    int valorSolicitado = int.Parse(Console.ReadLine());

    if (dinheiro[idCliente] >= valorSolicitado)
    {
        dinheiro[idCliente] -= valorSolicitado;
        Console.WriteLine($"Saldo realizado com sucesso!");

    }
    else
    {
        Console.WriteLine($"Saldo insuficiente");
    }

    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();//para o sistema e esperar o usuário dar um <Enter>
}

int BuscarCliente()
{
    ListarClientes();//desenha/exibe a lista de cliente
    Console.Write($"Digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;
    }

    return idCliente;
}


