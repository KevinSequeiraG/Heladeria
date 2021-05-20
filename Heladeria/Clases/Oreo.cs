using Heladeria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Clases
{
    class Oreo : ITopping
    {
        public double precio
        {
            get
            {
                return 300;
            }
        }
    }
}
