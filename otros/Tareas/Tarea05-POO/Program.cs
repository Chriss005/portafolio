using System;
using Tarea05_POO.Domain;

public class Program
{
    public static void Main(string[] args)
    {
        Circunferencia circunferencia = new Circunferencia();

        circunferencia.x = 1;
        circunferencia.y = 1;
        circunferencia.radio = 2;

        double areaCircunferencia = circunferencia.calcularArea();
        double perimetroCircunferencia = circunferencia.calcularPerimetro();
        Console.WriteLine("Area: " + areaCircunferencia);
        Console.WriteLine("Perimetro: " + perimetroCircunferencia);
        Console.WriteLine("Cordenada: (" + circunferencia.x + ", " + circunferencia.y + ")");
        circunferencia.moverCircunferencia(2, 2);git s
        Console.WriteLine("Nueva Cordenada: (" + circunferencia.x + ", " + circunferencia.y + ")");

        Cuadrado cuadrado = new Cuadrado();

        cuadrado.x = 1;
        cuadrado.y = 1;
        cuadrado.lado = 2;

        double areaCuadrado = cuadrado.calcularArea();
        double perimetroCuadrado = cuadrado.calcularPerimetro();
        Console.WriteLine("Area: " + areaCuadrado);
        Console.WriteLine("Perimetro: " + perimetroCuadrado);
        Console.WriteLine("Cordenada: (" + cuadrado.x + ", " + cuadrado.y + ")");
        cuadrado.moverCuadrado(2, 2);
        Console.WriteLine("Nueva Cordenada: (" + cuadrado.x + ", " + cuadrado.y + ")");



    }
}
