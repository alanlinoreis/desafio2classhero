// See https://aka.ms/new-console-template for more information

char nota;
string notastring;

Console.WriteLine("Informe uma nota: ");
notastring = Console.ReadLine();
nota = notastring[0];

if (nota == 'A')
    Console.WriteLine("A - Excelente");
if (nota == 'B')
    Console.WriteLine("B - Bom");
if (nota == 'C')
    Console.WriteLine("A - Regular");
if (nota == 'D')
    Console.WriteLine("A - Insuficiente");
if (nota == 'F')
    Console.WriteLine("A - Reprovado");

if (nota != 'A' && nota != 'B' && nota != 'C' && nota != 'D' && nota != 'F')
    Console.WriteLine("Nota invalida");
