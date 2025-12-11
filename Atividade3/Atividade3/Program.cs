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
    Console.WriteLine("A equação não possui raízes reais.");*/

/*3.
using System.Runtime.Serialization;


int soma = 0;

Console.Write($"Escolha um número qualquer positivo: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();


while (n < 0)
{
    Console.Write("Número inválido! Escolha um número positivo: ");
    n = int.Parse(Console.ReadLine());
    
}
Console.WriteLine("");
Console.WriteLine($"Os {n} primeiros números naturais são : ");

for (int i = 1; i <= n; i++)
{        Console.Write(i + " ");
         soma += i;
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine($"A soma de todos os número é: {soma}");*/


/*4.
int n;

do
{
    Console.Write($"Escolha um número qualquer positivo (Use o \'99\' para sair do loop): ");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (n == 99)
    {
        Console.WriteLine("Processo finalizado!");
        break;
    }

    while (n <= 0)
    {
        Console.Write("Número inválido! Escolha um número positivo: ");
        n = int.Parse(Console.ReadLine());

    }
    Console.WriteLine("");
    for (int i = 1; i <= 10; i++)
    {
        int resultado = n * i;
        Console.WriteLine($"{n} x {i} = {resultado}");

    }
    Console.WriteLine("");
} while (n != 99);*/

/*5.
string letra;
do {

    Console.WriteLine("Qual a instrução para sair do um loop?");
    Console.WriteLine("a. quit");
    Console.WriteLine("b. continue");
    Console.WriteLine("c. break");
    Console.WriteLine("d. exit");
    Console.WriteLine("");
    Console.WriteLine("Qual a opção correta? (Tecle x para sair) ");
    letra = Console.ReadLine();
    Console.WriteLine("__________________________________________________");

    if (letra == "c")
    {
        Console.WriteLine();
        Console.WriteLine("Parabéns você acertou, é a letra \'c. break\'!");
        break;
    }
    else if (letra == "x")
    {
        Console.WriteLine();
        Console.WriteLine("Processo finalizado!");
       
    }
    else
    {
        Console.WriteLine();
       
    }
} while (letra != "x");*/

/*6.

var x = 10;
var y = 20;

Console.WriteLine("Será apresentado os números pares de 10 a 20, excluíndo o 16");
Console.WriteLine();



Console.WriteLine("Incrementando de 2 em 2:");
for (int i = 10; i <= y; i += 2)
{
    if (i == 16)
    {
        
        continue;

    }
    Console.Write(i + " ");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Incrementando de 1 em 1:");

for (int i = x; i <= y; i++)
{
    if (i == 16)
    {
        continue;
    }
    Console.Write(i + " ");

}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Incrementando de 1 em 1 e finalizando no 16:");
for (int i = x; i <= y; i++)
{
    if (i == 16)
    {
        break;
    }
    Console.Write(i + " ");

}*/

/*7.

Console.Write("Informe a quantidade de linha para a árvore de *: ");
int linhas = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= linhas; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}*/


/*8.

Console.Write("Escolha um número para emitir o fatorial dele: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int i;

Console.Write($"O fatorial de {n} é representado por {n}! = {n}");

for (i = 1; i <= n; i++)
{
    int fatorial = n - i;
    Console.Write($"*{fatorial}");
    if (fatorial == 1)
    {
        break;
    }
}*/

/*9.
Console.WriteLine("Será apresentada as tabelas de multiplicação de 2 ao 6:");
Console.WriteLine();

int x = 2;
int y = 6;

do
{
    for (; x <= y; x++)
    {
        for (int i = 1; i <= 10; i++)
        {
            int multi = x * i;
            Console.WriteLine($"{x} x {i} = {multi}");

        }

        Console.WriteLine();
    }
} while (x <= y);*/

/*10. 

int nota;

do
{
    Console.WriteLine("_________________________________________________________________________________________");
    Console.Write("Informe a nota do aluno para apresentar a avaliação (digite 99 para parar o processo): ");
    nota = int.Parse(Console.ReadLine());
    Console.WriteLine();

    while (nota < 0 || nota > 10 & nota != 99)
    {
        Console.Write("Nota inválida! Informe uma nota de 0 a 10 para apresentar a avaliação (digite 99 para parar o processo): ");
        nota = int.Parse(Console.ReadLine());
        if (nota >= 0 & nota <= 10 || nota == 99)
        {
            Console.WriteLine("");
        }
    }
    switch (nota)
    {
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
            Console.WriteLine($"Com base na nota \"{nota}\" a avalição ficou F.");
            continue;

        case 5:
            Console.WriteLine($"Com base na nota \"{nota}\" a avalição ficou E.");
            continue;

        case 6:
            Console.WriteLine($"Com base na nota \"{nota}\"a avalição ficou C.");
            continue;

        case 7:
        case 8:
            Console.WriteLine($"Com base na nota \"{nota}\" a avalição ficou B.");
            continue;

        case 9:
            Console.WriteLine($"Com base na nota \"{nota}\" a avalição ficou A.");
            continue;

        case 10:
            Console.WriteLine($"Com base na nota \"{nota}\" a avalição ficou A+.");
            continue;

        case 99:
            Console.WriteLine("Processo encerrado!");
            break;
    }
} while (nota != 99);*/

//11.

double soma;

Console.WriteLine("Faça seu cálculo");
Console.WriteLine();

Console.Write("Informe o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Informe o operando (+, -, /, *): ");
string simb = Console.ReadLine();

Console.Write("Informe o primeiro número: ");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine();

if (simb == "/" & num2 == 0)
{
    Console.WriteLine("Não existe divisão por zero!!!");
    Console.WriteLine();
    Console.WriteLine($"{num1} / 0 = 8 (<- Símbolo de infinito)");

}
else
{
    switch (simb)
    {
        case "+":
            soma = num1 + num2;
            Console.WriteLine($"{num1} {simb} {num2} = {soma}");
            break;

        case "-":
            soma = num1 - num2;
            Console.WriteLine($"{num1} {simb} {num2} = {soma}");
            break;

        case "/":
            soma = num1 / num2;
            Console.WriteLine($"{num1} {simb} {num2} = {soma}");
            break;

        case "*":
            soma = num1 * num2;
            Console.WriteLine($"{num1} {simb} {num2} = {soma}");
            break;
    }
}

Console.ReadLine();
