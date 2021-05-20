using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.Clases;
using Heladeria.Interfaces;

namespace Heladeria
{
    public partial class frmPrincipal : Form
    {
        private OrdenCompra ordenCompra;
        private Helado helado;
        private ITopping topping;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            ordenCompra = new OrdenCompra();
            
            if (rdbChocolate.Checked)
            {
                helado = new Chocolate();                
            }
            else if (rdbCrema.Checked)
            {
                helado = new Crema(); 
            }
            else if (rdbFresa.Checked)
            {
                helado = new Fresa();
            }

            if (chkCaramelo.Checked)
            {
                topping = new Caramelo();
                ordenCompra.agregarTopping(topping);
            }
            if (chkMani.Checked)
            {
                topping = new Mani();
                ordenCompra.agregarTopping(topping);
            }
            if (chkOreo.Checked)
            {
                topping = new Oreo();
                ordenCompra.agregarTopping(topping);
            }
            ordenCompra.agregarHelado(helado);
            txtTotal.Text = ordenCompra.CalcularTotal().ToString();
        }
    }
}
