using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea05_POO.Domain
{
    internal class Circunferencia
    {
        private double x;
        private double y;
        private double radio;
        
        public Circunferencia(double x1, double y1, double radio1)
        {
            x = x1;
            y = y1;
            radio = radio1;
        }
        public double calcularArea()
        {
            return Math.PI * radio * radio;
        }

        public double calcularPerimetro()
        {
            return (2 * Math.PI) * radio; 
        }

        public void moverCircunferencia(double desplazamientoX, double desplazamientoY)
        {
            x += desplazamientoX;
            y += desplazamientoY;
        }
    }
}
