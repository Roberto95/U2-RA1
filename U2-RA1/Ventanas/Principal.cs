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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            Altas al = new Altas();
            al.ShowDialog();
            
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            Bajas b = new Bajas();
            b.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modificar m = new Modificar();
            m.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consultar c = new Consultar();
            c.ShowDialog();
        }
    }
}
