//1.
using System.Collections;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Threading.Channels;

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

/*2.

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
}*/


/*3.

float[,] notas = new float[2, 5];

Console.WriteLine("Informe as notas dos 5 alunos do grupo 1 e 2.\n");

for (int grupo = 0; grupo < 2; grupo++)
{
    Console.WriteLine($"\n--- GRUPO {grupo + 1} ---\n");

    for (int alunos = 0; alunos < 5; alunos++)
    {
        bool notaValida = false;


        while (!notaValida)
        {
            Console.Write($"A nota do grupo {grupo + 1} aluno {alunos + 1}: ");

            if (float.TryParse(Console.ReadLine(), out float nota))
            {

                if (nota >= 0 && nota <= 10)
                {
                    notas[grupo, alunos] = nota;
                    notaValida = true;
                }
                else
                {
                    Console.WriteLine("Escolha um número entre 0 e 10!");
                }

            }
            else
            {
                Console.WriteLine("Escolha um valor válido!");
            }


        }

    }
}

Console.WriteLine("\n--- RESULTADO ---\n");

for (int grupo = 0; grupo < 2; grupo++)
{
    float soma = 0;
    for (int alunos = 0; alunos < 5; alunos++)
    {
        soma += notas[grupo, alunos];
    }
    float media = soma / 5;
    Console.WriteLine($"A média do grupo {grupo + 1} é: {media}.");
}
*/

/*4.
ArrayList pessoas = new();

void Divisoria()
{
    Console.WriteLine("\n----------------------------");
}

void Exibir()
{
    Console.Write("\n--------Lista Atual--------\n");

    foreach (var pessoa in pessoas)
    {
        Console.Write(pessoa);
    }

    Divisoria();
}

void IncluirPessoas()
{

    Console.WriteLine("\nEscolha a quantidade de pessoas que deseja incluir na lista: ");
    int qtdPessoas = int.Parse(Console.ReadLine());

    for (int i = 0; i < qtdPessoas; i++)
    {
        Console.WriteLine($"\nInforme o nome da pessoas {i + 1}:");
        pessoas.Add(Console.ReadLine() + ", ");
        Console.WriteLine($"Informe o idade da pessoas {i + 1}:");
        pessoas.Add(int.Parse(Console.ReadLine()) + "   ");
    }

    Exibir();
}

void RemoverPessoas()
{
    Console.WriteLine("\nEscolha a quantidade de pessoas que deseja remover na lista: ");
    int qtdPessoas = int.Parse(Console.ReadLine());

    for (int i = 0; i < qtdPessoas; i++)
    {
        Console.WriteLine($"\nInforme o nome da pessoa {i+1} que deseja remover da lista: ");
        string nomeRemover = Console.ReadLine();

        while (!pessoas.Contains(nomeRemover + ", "))
        {
            Console.WriteLine($"A pessoa {nomeRemover} não foi encontrada na lista.");
            Console.WriteLine("Digite outro nome (ou 'sair' para cancelar): ");
            nomeRemover = Console.ReadLine();

            if (nomeRemover.ToLower() == "sair")
            {
                Console.WriteLine("Operação cancelada.");
                return;
            }

        }

        for (int j = 0; j < pessoas.Count; j++)
        {
            if (pessoas[j].ToString().StartsWith(nomeRemover + ", "))
            {
                pessoas.RemoveAt(j);
                pessoas.RemoveAt(j);
                Console.WriteLine($"A pessoa {nomeRemover} foi removida da lista.");
            }
        }
    }
    Exibir();
}

void EncerrarLista()
{
    Console.WriteLine("\nDeseja encerrar a lista [s/n]?");
    string encerrarlist = Console.ReadLine();

    while (encerrarlist.ToLower() != "s" && encerrarlist.ToLower() != "n")
    {
        Console.WriteLine("Resposta inválida. Por favor, responda com 's' para sim ou 'n' para não.");
        encerrarlist = Console.ReadLine();
    }
    if (encerrarlist.ToLower() == "s")
    {
        Console.WriteLine("Fim do processo...");
    }
    else if (encerrarlist.ToLower() == "n")
    {
        Divisoria();
        Escolha();
    }
}

void Escolha()
{
    if (pessoas.Count > 0)
    {
        Console.WriteLine("\nDigite \"i\" para incluir, ou \"r\" para remover alguma pessoa da lista");
        string resposta = Console.ReadLine();

        while (resposta.ToLower() != "i" && resposta.ToLower() != "r")
        {
            Console.WriteLine("Resposta inválida. Por favor, responda com 'i' para incluir ou 'r' para remover.");
            resposta = Console.ReadLine();
        }

        if (resposta.ToLower() == "r")
        {
            RemoverPessoas();
            EncerrarLista();
        }
        else if (resposta.ToLower() == "i")
        {
            IncluirPessoas();
            EncerrarLista();

        }
    }
}

// Inicio do programa
IncluirPessoas();
EncerrarLista();
*/

//Exercício.

class Aluno {

    public string Nome { get; set; }
    public double Nota { get; set; }

    static void Main()
    {
        List<string> nome = new() { "Maria", "Manoel", "Amanda", "Carlos", "Jaime", "Debora", "Alicia", "Sandra", "Marta", "Sueli" };
        List<double> nota = new() { 8.75, 6.95, 7.25, 6.55, 8.50, 5.95, 9.25, 5.55, 7.85, 9.15 };

        void Divisoria()
        {
            Console.WriteLine("\n----------------------------");
        }

        void ExibirLista()
        {
            Console.Write("\n--------Lista Atual--------\n");
            Console.WriteLine("Nome e a nota dos alunos\n");
           
            List<Aluno> itens = new();

            for (int i = 0; i < nome.Count; i++)
            {
                itens.Add(new Aluno { Nome = nome[i], Nota = nota[i] });
            }


            //ordenado por valor escolhido
            var valorMinimo = 7;
            var ordenadoPorValorEscolhido = itens.Where(i => i.Nota > valorMinimo).OrderBy(i => i.Nome).ToList();

            foreach (var item in ordenadoPorValorEscolhido)
                {
                    Console.WriteLine($"Aluno: {item.Nome} - Nota: {item.Nota}");
                }

            double media = nota.Average();
            Console.WriteLine($"\nA média da turma é: {media}");
        }

        void IncluirAluno()
        {

            Console.WriteLine("\nEscolha a quantidade de aluno que deseja incluir na lista: ");
            int qtdAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine($"\nInforme o nome da pessoas {i + 1}:");
                nome.Add(Console.ReadLine());
                Console.WriteLine($"Informe o nota da pessoas {i + 1}:");
                nota.Add(double.Parse(Console.ReadLine()));
            }

            ExibirLista();
        }

        void RemoverPessoas()
        {
            Console.WriteLine("\nEscolha a quantidade de pessoas que deseja remover na lista: ");
            int qtdAlunos = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine($"\nInforme o nome da pessoa {i + 1} que deseja remover da lista: ");
                string nomeRemover = Console.ReadLine();

                while (!nome.Contains(nomeRemover))
                {
                    Console.WriteLine($"A pessoa {nomeRemover} não foi encontrada na lista.");
                    Console.WriteLine("Digite outro nome (ou 'sair' para cancelar): ");
                    nomeRemover = Console.ReadLine();

                    if (nomeRemover.ToLower() == "sair")
                    {
                        Console.WriteLine("Operação cancelada.");
                        return;
                    }

                }

                for (int j = 0; j < nome.Count; j++)
                {
                    if (nome[j].ToString().StartsWith(nomeRemover))
                    {
                        nome.RemoveAt(j);
                        nota.RemoveAt(j);
                        Console.WriteLine($"A pessoa {nomeRemover} foi removida da lista.");
                    }
                }
            }
            ExibirLista();
        }


        void Escolha()
        {
            if (nome.Count > 0)
            {
                Console.WriteLine("\nDigite \"i\" para incluir, ou \"r\" para remover alguma pessoa da lista");
                string resposta = Console.ReadLine();

                while (resposta.ToLower() != "i" && resposta.ToLower() != "r")
                {
                    Console.WriteLine("Resposta inválida. Por favor, responda com 'i' para incluir ou 'r' para remover.");
                    resposta = Console.ReadLine();
                }

                if (resposta.ToLower() == "r")
                {
                    RemoverPessoas();
                    EncerrarLista();
                }
                else if (resposta.ToLower() == "i")
                {
                    IncluirAluno();
                    EncerrarLista();

                }
            }
        }

        void EncerrarLista()
        {
            Console.WriteLine("\nDeseja encerrar a lista [s/n]?");
            string encerrarlist = Console.ReadLine();

            while (encerrarlist.ToLower() != "s" && encerrarlist.ToLower() != "n")
            {
                Console.WriteLine("Resposta inválida. Por favor, responda com 's' para sim ou 'n' para não.");
                encerrarlist = Console.ReadLine();
            }
            if (encerrarlist.ToLower() == "s")
            {
                Console.WriteLine("Fim do processo...");
            }
            else if (encerrarlist.ToLower() == "n")
            {
                Divisoria();
                Escolha();
            }
        }

        ExibirLista();
        Escolha();

    } 
}












