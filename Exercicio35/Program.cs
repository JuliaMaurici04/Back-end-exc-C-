Console.WriteLine("quantos vezes o programa ira rodar ?");

int Nescolhido = int.Parse(Console.ReadLine());
Console.WriteLine("------------------------------------");
while (Nescolhido >= 1)
{
    Console.WriteLine(" digite o primeiro numero:");
    Console.WriteLine("");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("------------------------------------");
    Console.WriteLine(" digite o segundo numero:");
    Console.WriteLine("");
    int n2 = int.Parse(Console.ReadLine());
    if (n2 < n1)
    {
        Console.WriteLine("");
        Console.WriteLine($" o numero {n1} é maior");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("");

    }
    else if (n1 < n2)
    {
        Console.WriteLine("");
        Console.WriteLine($" o numero {n2} é maior");
        Console.WriteLine("-----------------------");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine($" os numeros são iguais");
        Console.WriteLine("-----------------------");
        Console.WriteLine("");
    }

    Nescolhido--;
}
