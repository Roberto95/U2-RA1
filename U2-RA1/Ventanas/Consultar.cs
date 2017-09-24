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

namespace Ventanas
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            //si tiene contenido el archivo a buscar, se muestra en el textbox contenido
            //el cual esta bloqueado, ya que se esta utilizando unicamente para mostrar

            if (!string.IsNullOrEmpty(op.buscar(txtArchivo.Text)))
            {
                txtContenido.Text = op.buscar(txtArchivo.Text);
            }
            else
            {
                MessageBox.Show("Archivo inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
