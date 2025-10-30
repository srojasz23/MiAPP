using MiAPP;
using System;
using System.Linq;


var libros = Book.Books();
var autores = Author.Authors();

// monstrar por consola los 3 libros con mas ventas  

Console.WriteLine("Los top 3 libros con ventas");
var top3 = libros.OrderByDescending(l => l.Sales).Take(3);
foreach(var l in top3)
    Console.WriteLine($"{l.Title} - { l.Sales} millones");
Separador(); 


void Separador()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("--------------------------");
    Console.ResetColor();
}




