﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNATools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           
        }

        private void mnuCalculateTm_Click(object sender, EventArgs e)
        {

        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            frmDNAmer newFrm = new frmDNAmer();
            newFrm.MdiParent = this;
            newFrm.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuSequenceReverse_Click(object sender, EventArgs e)
        {

        }
    }
}
