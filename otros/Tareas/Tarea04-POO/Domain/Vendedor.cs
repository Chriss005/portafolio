using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Tarea04_POO.Domain
{
    public class Vendedor
    {
        public string nombre;

        public string darInformacion(Camisa camisa)
        {
            string info = "";
            if (camisa.diseño == true)
            {
                info = "con mangas";
            }
            else
            {
                info = "sin mangas";
            }
            return "Precio: " + camisa.precio + ", Talla: " + camisa.talla + ", Color: " + camisa.color + ", Diseño: " + info;
        }
        public string darInformacion(Pantalon pantalon)
        {
            return "Precio: " + pantalon.precio + ", Talla: " + pantalon.talla + ", Color: " + pantalon.color;
        }
        public string darInformacion(Zapato zapato)
        {
            string info = "";
            if (zapato.diseño == true)
            {
                info = "con cordon";
            }
            else
            {
                info = "sin cordon";
            }
            return "Precio: " + zapato.precio + ", Talla: " + zapato.talla + ", Color: " + zapato.color+ ", Diseño: " + info;
        }

        public double vender(double precio)
        {
            double total = 0;
            return total += precio;
        }
    }
}
