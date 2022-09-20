using ConsoleAppV22;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hola, Mundo!");
        List<Libros> lst_libros = new List<Libros>();
        Libros obj = new Libros();
        lst_libros.Add(obj);
        Console.WriteLine("El número de elementos de ls lista es: " + lst_libros.Count);
    }
}