﻿using BusinessLogicLayer;
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
    public partial class Bajas : Form
    {
        public Bajas()
        {
            InitializeComponent();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            //se implementa el metodo eliminar
            op.eliminarArchivo(txtArchivo.Text);
            txtArchivo.Clear();
        }
    }
}
