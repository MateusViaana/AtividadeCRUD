﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AtidadeEliasCRUD.Formularios;

namespace AtidadeEliasCRUD.Formularios
{
    public partial class TelaIncial : Form
    {
        public TelaIncial()
        {
            InitializeComponent();
           
        }

       

        private void btADD_Click(object sender, EventArgs e)
        {
            Cadastrar formm = new Cadastrar();
            formm.ShowDialog();
        }
    }
}
