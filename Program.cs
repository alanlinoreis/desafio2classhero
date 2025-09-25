using System;

public enum Escala
{
    Celsius,
    Fahrenheit
}

public class Temperatura
{
    private double valor;
    private Escala escala;

    public Temperatura(double valor, Escala escala)
    {
        this.valor = valor;
        this.escala = escala;
    }

    public double EmCelsius()
    {
        return escala == Escala.Celsius ? valor : (valor - 32) * 5.0 / 9.0;
    }

    public double EmFahrenheit()
    {
        return escala == Escala.Fahrenheit ? valor : (valor * 9.0 / 5.0) + 32;
    }

    public override string ToString()
    {
        return $"{valor:F2}°{(escala == Escala.Celsius ? "C" : "F")}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma temperatura em Celsius
        Temperatura t1 = new Temperatura(25, Escala.Celsius);
        Console.WriteLine($"{t1} = {t1.EmFahrenheit():F2}°F");

        // Criando uma temperatura em Fahrenheit
        Temperatura t2 = new Temperatura(77, Escala.Fahrenheit);
        Console.WriteLine($"{t2} = {t2.EmCelsius():F2}°C");
    }
}
