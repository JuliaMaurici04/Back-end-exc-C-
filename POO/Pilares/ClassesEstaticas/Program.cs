// See https://aka.ms/new-console-template for more information

using ClassesEstaticas;

Console.WriteLine("Bem vindo ao programa!");
Console.WriteLine();

Console.WriteLine($"Digite o 1° numero: ");
float a = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o 2° numero: ");
float b = float.Parse(Console.ReadLine());

//uso da classe estatica de forma auxiliar
float r = CalculosMatematicos.Somar(a, b);
Console.WriteLine($"Soma: {r}");

 r = CalculosMatematicos.Subtrair(a, b);
 Console.WriteLine($"Subtração: {r}");

 r = CalculosMatematicos.Multiplicar(a, b);
 Console.WriteLine($"Multiplicação: {r}");

  if( b == 0 )
        {
            Console.WriteLine($"Divisao Invalida");
        }

    else
        {
            r = CalculosMatematicos.Dividir(a, b);
            Console.WriteLine($"Divisao: {r}");
        }


//Solicitar ao usuario 2 numeros reais e informar qual e o maior e qual e o menor dos numeros. 
// Para isso voce deve utilizar a classe Math, utilitaria do C#


Console.Write($"DIgite o primeiro numero:");
float n1 = float.Parse(Console.ReadLine());

Console.Write($"DIgite o segundo numero:");
float n2 = float.Parse(Console.ReadLine());

if( n1 == n2)
{
    Console.WriteLine($"Os dois numeros sao iguais");
}

else
{
    Console.WriteLine($"Maior e: {Math.Max(n1, n2)}");  
    Console.WriteLine($"Menor e: {Math.Min(n1, n2)}");
}



















//Consolle>Writeline($"Valor do PI e: Math.pi")