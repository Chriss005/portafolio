using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea05_POO.Domain
{
    internal class Segmento
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;

        public Segmento(double x3, double y3, double x4, double y4)
        {
            x1 = x3;
            y1 = y3;
            x2 = x4;
            y2 = y4;
        }
        public double calcularLongitud()
        {
            return Math.Sqrt(Math.Pow((xFinal - xInicial), 2) + Math.Pow((yFinal - yInicial), 2));
        }

        public void moverSegmento(double desplazamientoX, double desplazamientoY)
        {
            x1 = desplazamientoX;
            y1 = desplazamientoY;
            x2 = desplazamientoX;
            y2 = desplazamientoY;
        }
    }

}
