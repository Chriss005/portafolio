using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea05_POO.Domain
{
    internal class Triangulo
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;
        private double x3;
        private double y3;

        public Triangulo(double cX1, double cY1, double cX2, double cY2, double cX3, double cY3)
        {
            x1 = cX1;
            y1 = cY1;
            x2 = cX2;
            y2 = cY2;
            x3 = cX3;
            y3 = cY3;
        }
        public double calcularArea()
        {
            return 0;
        }
        public double calcularPerimetro()
        {
            return 0;
        }
        public void moverTriangulo(double desplazamientoX, double desplazamientoY)
        {
            x1 = desplazamientoX;
            y1 = desplazamientoY;
            x2 = desplazamientoX;
            y2 = desplazamientoY;
            x3 = desplazamientoX;
            y3 = desplazamientoY;
        }
    }
}
