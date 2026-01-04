/* Classes e Métodos
1.*/

/* using System;

Carro carro = new Carro();
carro.Tipo ("Sedan", "Chevrolet", "Onix", 2016, 110);
carro.Tipo ("SUV", "Ford", "EcoSport", 2018, 120);

Console.ReadLine();

class Carro
{
    public string Modelo;
    public string Montadora;
    public string Marca;
    public int Ano;
    public int Potencia;
   
    public void Tipo (string modelo, string montadora, string marca, int ano, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
        Console.WriteLine($"Modelo: {Modelo}, Montadora: {Montadora}, Marca: {Marca}, Ano: {Ano}, Potência: {Potencia}cv");
        Console.WriteLine($"Acelerando o meu {Marca}");
        Console.WriteLine();
    } 
}
*/

//using System.ComponentModel.Design;
//using System.Security.Cryptography.X509Certificates;

//Carro car = new();
//int velocidadeInicial = 0;

//Console.WriteLine(car.VelocidadeMaxima("Sedan", "Chevrolet", 10));
//car.AumentarPotencia(10);
//Console.WriteLine($"A velocidade inicial é: {velocidadeInicial} km/h");
//car.Valorfinal(ref velocidadeInicial);
//Console.WriteLine($"Depois voltou para o velocidade inicial: {velocidadeInicial} km/h");
//Console.Write("Informe a potência em km/h: ");
//int potencia = int.Parse(Console.ReadLine());
//Console.WriteLine();
//car.AumentarPotenciaVelocidade(potencia, out double novaVelocidade);
//car.ExibirInfo(2021 ,marca: "Chevrolet",modelo: "Onix",potencia: 110, montadora: "Casa do Tonho");
//Carro.ObterValorIPVA = 100.00;
//Console.WriteLine($"O valor do IPVA é: {Carro.IPVA()}");
//car.Ano = 2029;
//car.ExibirAno();

using CarroEnum;



Console.WriteLine("As opções de cores para os carros:\n");
Console.WriteLine($"A cor {Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"A cor {Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"A cor {Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"A cor {Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"A cor {Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"A cor {Cores.Azul} - {(int)Cores.Azul}");

Console.Write("\nEscolha uma cor para o seu carro (informe o número correspondente): ");
int cor = int.Parse(Console.ReadLine());

var Cor = (Cores) cor;
Console.WriteLine($"\nVocê selecionou a cor: {Cor.ToString()}");

Console.ReadLine();

class Carro
{
    public string Modelo;
public string Montadora;

//public double VelocidadeMaxima(string modelo, string montadora, int potencia)
//{
//    Modelo = modelo;
//    Montadora = montadora;
//    return potencia * 1.75;
//}
public int AumentarPotencia(int potencia)
{
    potencia += 3;
    Console.WriteLine(potencia);
    return potencia;
}
public int Valorfinal(ref int velocidadeAdquida)
{
    velocidadeAdquida += 5;
    Console.WriteLine($"Velocidade adquirida: {velocidadeAdquida} km/h");
    return velocidadeAdquida;
}
public int AumentarPotenciaVelocidade(int potencia, out double novaVelocidade)
{
    novaVelocidade = (potencia + 7) * 1.75;
    //potencia += 3;
    Console.WriteLine($"A potência inicial: {potencia} km/h");
    Console.WriteLine($"A nova velocidade é: {novaVelocidade} km/h");
    return potencia;
}
public void ExibirInfo(int ano, string modelo = "Civic", string montadora = "Eurovia", string marca = "Ford", int potencia = 0)
{
    Console.WriteLine($"Marca: {marca}\nModelo: {modelo}\nAno: {ano}\nMontadora: {montadora}\nPotência: {potencia}");
}
public static double ObterValorIPVA;

public static double IPVA()
{
    return ObterValorIPVA * 4;
}
private int ano;
public int Ano
{
    get { return ano; }
    set
    {
        if (value < 2000)
            ano = 2000;
        else if (value > 2022)
            ano = 2022;
        else
            ano = value;
    }
}
public void ExibirAno()
{
    //Console.WriteLine($"Ano do carro: {Ano}");

}
}


//using System.ComponentModel.DataAnnotations;



//Cliente cliente = new("Ana Silva", "teste@gmail.com", 30);

//Cliente.ExibirInfo(cliente.Nome, cliente.Email, cliente.Idade );
//Cliente.ExibirInfo(cliente.Nome, cliente.Email);

//Console.ReadLine();

/*public struct Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }

    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
                idade = 18;
            else
                idade = value;
        }
    }
    public Cliente(string? nome, string? email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"Nome: {nome}, Email: {email}, Idade: {idade}");
    }
}
*/


