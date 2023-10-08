using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoLogin
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod;
            string nom;
            float precio;

            cod = cmbProducto.SelectedIndex;
            nom = cmbProducto.SelectedItem.ToString();
            precio = cmbProducto.SelectedIndex;

            switch (cod)

            {

                case 0: lblCodigo.Text = "0001"; break;
                case 1: lblNombre.Text = "0022"; break;
                case 2: lblCodigo.Text = "0033"; break;
                default: lblCodigo.Text = "0044"; break;
            }
        
            switch (nom)
            {
                case "Labial": lblNombre.Text = "Labial"; break;
                case "Tintura": lblNombre.Text = "Tintura"; break;
                case "Arqueador": lblNombre.Text = "Arqueador"; break;
                case "Pintura de uñas": lblNombre.Text = "Pintura de uñas"; break;
            }

            switch (precio)
            {
                case 0: lblPreci.Text = "110"; break;
                case 1: lblPreci.Text = "250"; break;
                case 2 : lblPreci.Text = "150"; break;
                default: lblPreci.Text = "300"; break;
            }

        }
    }
}
