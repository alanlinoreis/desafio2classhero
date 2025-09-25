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
        Console.Write("Digite a temperatura corporal em Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double valorTemp))
        {
            Temperatura temp = new Temperatura(valorTemp, Escala.Celsius);

            if (temp.EmCelsius() <= 37.5)
            {
                Console.WriteLine("Entrada permitida.");
            }
            else
            {
                Console.WriteLine("Entrada negada por febre.");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido.");
        }
    }
}
