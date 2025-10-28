Console.WriteLine("quantos numero voce ira digitar");
int Nescolhido = int.Parse(Console.ReadLine());

while (Nescolhido >= 1)
{
    Console.WriteLine(" gitite o numero:");
    int n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        Console.WriteLine("");
        Console.WriteLine($" o numero {n} é par");
    }

    Nescolhido--;
}