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
    public partial class Altas : Form
    {
        public Altas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            //como el metodo devuelve un bool, con el if se checa si es true, se crea
            //si no, muestra un mensaje de ereror
            if(op.EscribirCaracteres(txtContenido.Text, txtArchivo.Text))
            {
                txtArchivo.Clear();
                txtContenido.Clear();
                MessageBox.Show("Archivo creado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Error en la creacion del archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
