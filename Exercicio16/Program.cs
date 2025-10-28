double salario;

string cargo;

Console.WriteLine("digite seu seu salario");
salario = int.Parse(Console.ReadLine());



Console.WriteLine("-----------------------------------");
Console.WriteLine("* qual dos seguintes é seu cargo: *");
Console.WriteLine("*                                 *");
Console.WriteLine("*             produção            *");
Console.WriteLine("*             administração       *");
Console.WriteLine("*             diretoria           *");
Console.WriteLine("-----------------------------------");
cargo = Console.ReadLine();
Console.WriteLine("");

if (cargo == "produção")
{
    salario = salario + (salario * 0.065);
    Console.WriteLine("seu novo salario é de: " + salario);
}
else if (cargo == "administração")
{

    salario = salario + (salario * 0.075);
    Console.WriteLine("seu novo salario é de: " + salario);
}
else if (cargo == "diretoria")
{
    salario = salario + (salario * 0.12);
    Console.WriteLine("seu novo salario é de: " + salario);
}

