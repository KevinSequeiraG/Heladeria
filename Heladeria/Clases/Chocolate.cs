using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heladeria.Clases
{
    class Chocolate : Helado
    {
        public Chocolate()
            : base()
        {
        }

        public override double Costo 
        {
            get
            {
                return 450;
            } 
        }
    }
}
