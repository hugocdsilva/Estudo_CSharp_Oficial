//1.
using System.Runtime.Serialization;

String[] frutas = { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora", "Kiwi" };

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

static void ExibirArray(string[] frutas) 
{
foreach (var fruta in frutas)
{
    Console.WriteLine($"A fruta é {fruta}");
}
}

/*d.
Console.WriteLine("Ordem a coleção de frutas na ordem ascendente:\n");
Array.Sort(frutas);
ExibirArray(frutas);
*/

//e.
    Console.WriteLine("Descrição das frutas em ordem reversa:\n");
Array.Reverse(frutas);
ExibirArray(frutas);



/*for (int i = 10; i < frutas.Length; i--)
{
    Console.WriteLine($"A fruta {frutas[i]} é na ordem {i}");
    if (i == 0)
    {
        break;
    }
}
*/

Console.ReadLine();

