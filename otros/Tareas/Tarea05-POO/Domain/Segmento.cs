using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea05_POO.Domain
{
    internal class Segmento
    {
        public double xInicial;
        public double yInicial;
        public double xFinal;
        public double yFinal;

        public double calcularLongitud()
        {
            return Math.Sqrt(Math.Pow((xFinal - xInicial), 2) + Math.Pow((yFinal - yInicial), 2));
        }

        public void moverSegmento(double nuevaX1, double nuevaY1, double nuevaX2, double nuevaY2)
        {
            xInicial = nuevaX1;
            yInicial = nuevaY1;
            xFinal = nuevaX2;
            yFinal = nuevaY2;
        }
    }

}
