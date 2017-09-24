using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            frmDatos dat = new frmDatos();
            dat.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            guardarEntxt g = new guardarEntxt();
            try {
                if (g.escribirCaracteres(txtUsuario.Text, txtPassword.Text))
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("No deje campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {
                MessageBox.Show("Error de insercion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
