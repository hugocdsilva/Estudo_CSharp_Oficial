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

using System.Security.Cryptography.X509Certificates;

Carro car = new();
int velocidadeInicial = 0;

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

Carro.ObterValorIPVA = 100.00;
Console.WriteLine($"O valor do IPVA é: {Carro.IPVA()}");


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

    public static double IPVA ()
    {
        return ObterValorIPVA * 4;
    }
    
}




