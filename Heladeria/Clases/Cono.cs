using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heladeria.Interfaces;

namespace Heladeria
{
    class Cono
    {
        public Helado helado{ get; set; }

        public List<ITopping> toppings = new List<ITopping>();
    }
}
