using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heladeria.Interfaces;

namespace Heladeria.Clases
{
    class OrdenCompra
    {
        private Cono cono;

        public OrdenCompra()
        {
            cono = new Cono();
        }
        public void agregarHelado(Helado helado)
        {
            cono.helado = helado;
        }
        public void agregarTopping(ITopping itopping)
        {
            cono.toppings.Add(itopping);
        }
        public double CalcularTotal()
        {
            double precioTopping = 0;
            foreach (ITopping topping in cono.toppings)
            {
                precioTopping += topping.precio;
            }
            return cono.helado.Costo + precioTopping;
        }
    }
}

