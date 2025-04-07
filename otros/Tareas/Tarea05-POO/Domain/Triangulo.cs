using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea05_POO.Domain
{
    internal class Triangulo
    {
        public double x;
        public double y;
        public double baseT;
        public double altura;
        public double lado;

        public double calcularArea()
        {
            return (baseT * altura)/2;
        }
        public double calcularPerimetro()
        {
            return baseT + lado + lado;
        }
        public void moverTriangulo(double nuevaX, double nuevaY)
        {
            x = nuevaX;
            y = nuevaY;
        }
    }
}
