﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProgram
{
    public partial class frmMainProgram : Form
    {
        frmNevjegy nevjegy = new frmNevjegy();
        

        public frmMainProgram()
        {
            InitializeComponent();
        }

       

        private void TsmMenuNevjegy_Click(object sender, EventArgs e)
        {
            nevjegy.ShowDialog();
        }

        private void TsmMenuKIlep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adatokFelviteleMódosításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRogzites rogzites = new frmRogzites();
            rogzites.ShowDialog();
        }

        private void TsmMenuLekerdez_Click(object sender, EventArgs e)
        {
            frmLekerdezes lekerdezes = new frmLekerdezes();
            lekerdezes.ShowDialog();
        }
    }
}
