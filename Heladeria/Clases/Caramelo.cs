using Heladeria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Clases
{
    class Caramelo : ITopping
    {
        public double precio
        {
            get
            {
                return 200;
            }
        }

    }
}
