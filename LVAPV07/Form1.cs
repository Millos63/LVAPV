﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVAPV07
{
    public partial class FrmUno : Form
    {
        public FrmUno()
        {
            InitializeComponent();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnLlamarForma_Click(object sender, EventArgs e)
        {
            FrmDos frmDos = new FrmDos();
            frmDos.Show();

        }
    }
}
