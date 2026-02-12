//1.
using System.Runtime.Serialization;

//String[] frutas = { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora", "Kiwi" };

/*Console.WriteLine("Descrição das frutas em for:\n");

a.
for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"A fruta {frutas[i]} é na ordem {i}");
}

Console.WriteLine("\n\nDescrição das frutas em foreach:\n");

foreach (var fruta in frutas)
{
    Console.WriteLine($"A fruta é {fruta}");
}*/


/*b.
Console.WriteLine("Descrição das frutas da segunda e penúltima, são:\n");

int f_segunda = frutas.Length - (frutas.Length - 1);
int f_penultima = frutas.Length - 2;

Console.WriteLine($"A fruta {frutas[f_segunda]} é a segunda opção.");
Console.WriteLine($"A fruta {frutas[f_penultima]} é a penúltima opção.");
*/

/*static void ExibirArray(string[] frutas) 
{
foreach (var fruta in frutas)
{
    Console.WriteLine($"A fruta é {fruta}");
}
}
*/
/*d.
Console.WriteLine("Ordem a coleção de frutas na ordem ascendente:\n");
Array.Sort(frutas);
ExibirArray(frutas);
*/

/*e.
    Console.WriteLine("Descrição das frutas em ordem reversa:\n");
Array.Reverse(frutas);
ExibirArray(frutas);
*/

//2.

int[] numeros = { 3, 6, 9 };
const string palavra_Chave = "fim";

Console.WriteLine("Os números são:");
foreach (var numero in numeros)
{
    Console.Write($"{numero} ");
}

while (true)
{
    Console.WriteLine("\nInforme um número inteiro para adivinhar alguns dos 3 números secretos, ou escreva \"fim\" para encerrar o processo:");
    string procurar = Console.ReadLine();

    if ( procurar.ToLower() == palavra_Chave)
    {
        Console.WriteLine("Encerrando procura...");
        break;
       
    }

    if(int.TryParse(procurar, out int numeroProcurado))
    {
        bool encontrado = false;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numeroProcurado)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
            Console.WriteLine($"O número procurado {numeroProcurado} existe na lista");
        else        
            Console.WriteLine($"O número procurado {numeroProcurado} NÀO existe na lista");

        Console.WriteLine();
    }
}

Console.ReadLine();