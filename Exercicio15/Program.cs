float n1, n2, n3, n4, media;



Console.WriteLine("digite a primeira nota");
n1 = float.Parse(Console.ReadLine()); ;

Console.WriteLine("digite a segunda nota");
n2 = float.Parse(Console.ReadLine()); ;

Console.WriteLine("digite a terceira nota");
n3 = float.Parse(Console.ReadLine()); ;

Console.WriteLine("digite a quarta nota");
n4 = float.Parse(Console.ReadLine()); ;


media = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine("Media: " + media);

if (media >= 7)
{
    Console.WriteLine("aprovado");
}
else if (media >= 5 && media < 7)
{
    Console.WriteLine("recuperacao");
}
else
{
    Console.WriteLine("reprovado");
}
