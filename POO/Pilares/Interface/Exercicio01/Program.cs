using Exercicio01;


//Retangulo
System.Console.WriteLine($"Bem vindo ao programa Cálculos de Geometria :) ====");

System.Console.WriteLine($"Vamos calcular o Retângulo ");

//Altura e Largura
System.Console.Write($"Digite a Largura do Retângulo: ");
float l = float.Parse(Console.ReadLine());
Console.Write($"Digite a Altura do Retângulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Agora vamos calcular a área do círculo");
Console.Write($"Informe o raio do círculo: ");
float r = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = r;
circulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Fim do programa");
Console.WriteLine();
