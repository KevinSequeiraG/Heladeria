﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Clases
{
    class Crema : Helado
    {

        public override double Costo
        {
            get
            {
                return 500;
            }
        }
    }
}
