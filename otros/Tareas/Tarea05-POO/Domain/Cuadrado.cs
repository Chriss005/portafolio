using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea05_POO.Domain
{
    internal class Cuadrado
    {
        private double x;
        private double y;
        private double lado;

        public Cuadrado(double x1, double y1, double lado1)
        {
            x = x1;
            y = y1;
            lado = lado1;
        }
        public double calcularArea()
        {
            return lado * lado;
        }
        public double calcularPerimetro()
        {
            return 4 * lado;
        }
        public void moverCuadrado(double desplazamientoX, double desplazamientoY)
        {
            x += desplazamientoX;
            y += desplazamientoY;
        }
    }
}
