using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea05_POO.Domain
{
    internal class Rectangulo
    {
        public double x;
        public double y;
        public double lado;

        public double calcularArea()
        {
            return lado * lado;
        }
        public double calcularPerimetro()
        {
            return 4 * lado;
        }
        public void moverRectangulo(double nuevaX, double nuevaY)
        {
            x = nuevaX;
            y = nuevaY;
        }
    }
}
