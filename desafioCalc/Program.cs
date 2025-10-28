int n1, n2;

Console.WriteLine("DIgite o primeiro numero");
n1 = int.Parse( Console.ReadLine() );
Console.WriteLine("DIgite o segundo numero");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"O primeiro numero e maior: {n1}");
}

else
{
    Console.WriteLine($"O segundo numero e maior: {n2}");
}
