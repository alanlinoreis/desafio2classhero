// See https://aka.ms/new-console-template for more information

Console.WriteLine("Informe a temperatura do usuario: ");
double temp = Convert.ToDouble(Console.ReadLine());

if (temp <= 37.5)
    Console.WriteLine("Entrada permitida.");
else
    Console.WriteLine("Entrada negada por febre.");

