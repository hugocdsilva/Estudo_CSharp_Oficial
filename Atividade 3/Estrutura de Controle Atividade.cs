/*1.
Console.WriteLine("Informe 3 números inteiros para sabermos qual será o maior:");
Console.WriteLine();

Console.WriteLine("Informe o primeiro número:");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Informe o segundo número:");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine();5

Console.WriteLine("Informe o terceiro número:");
int n3 = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Número 1 é: {n1}");
Console.WriteLine($"Número 2 é: {n2}");
Console.WriteLine($"Número 3 é: {n3}");

if (n1 > n2 || n1 > n3)
{
    Console.WriteLine($"O primeiro número: {n1} é o maior!");
}
else if (n2 > n3)
{
    Console.WriteLine($"O segundo número: {n2} é o maior!");
}
else
{
    Console.WriteLine($"O terceiro número: {n3} é o maior!");}*/


/*2.
using System;

Console.WriteLine("Informe os para as letras A, B e C, e depois faça a equação: ax² + bx + C = 0 ");
Console.WriteLine();

Console.WriteLine("Informe o número para A:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Informe o número para B:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Informe o número para C:");
double c = double.Parse(Console.ReadLine());
Console.WriteLine();

var x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
var x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a); 
Console.WriteLine($"O valor de X1 é: {x1}");
Console.WriteLine($"O valor de X2 é: {x2}");
var delta = b * b - 4 * a * c;
if (delta > 0) { 
    Console.WriteLine("A equação possui duas raízes reais e distintas.");
} 
else if (delta == 0) { 
    Console.WriteLine("A equação possui uma raiz real dupla.");
} 
else { 
    Console.WriteLine("A equação não possui raízes reais.");
