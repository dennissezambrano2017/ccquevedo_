﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccquevedo_
{
    public partial class CrearExcel : Form
    {
        public CrearExcel()
        {
            InitializeComponent();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form form = new Nuevo();
            form.Show();
        }
    }
}