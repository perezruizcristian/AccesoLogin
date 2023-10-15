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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Deve ingresar su Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Deve ingresar una Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (String.IsNullOrEmpty(textBox3.Text))
                    {
                        MessageBox.Show("Deve ingresar su Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(textBox4.Text))
                        {
                            MessageBox.Show("Deve ingresar una Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            if (String.IsNullOrEmpty(textBox5.Text))
                            {
                                MessageBox.Show("Deve ingresar su Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (String.IsNullOrEmpty(textBox5.Text))
                                {
                                    MessageBox.Show("Deve ingresar una Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {

                                    if (String.IsNullOrEmpty(textBox6.Text))
                                    {
                                        MessageBox.Show("Deve ingresar una Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {

                                        MessageBox.Show("Deve ingresar una Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }

                            }

                        }

                    }

                }

            }
        }
    }
}
