/* Classes e Métodos
1.*/

using System;

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
