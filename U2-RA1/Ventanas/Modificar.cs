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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            //si el archivo que se busca(cuyo nombre se asigno como parametro en el metodo)
            //tiene contenido, este se mostrara en el textbox de contenido, listo para modificarse
            //y se bloqueara el textbox con el nombre, para que no se cambie
            if (!string.IsNullOrEmpty(op.buscar(txtArchivo.Text)))
            {
                txtArchivo.Enabled = false;
                txtContenido.Text = op.buscar(txtArchivo.Text);
            }else
            {
                MessageBox.Show("Archivo inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            op.modificar(txtContenido.Text, txtArchivo.Text);
            txtArchivo.Clear();
            txtContenido.Clear();
            txtArchivo.Enabled = true;
        }
    }
}
