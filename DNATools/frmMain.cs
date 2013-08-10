﻿using System;
using System.Collections;
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
            this.WindowState = FormWindowState.Maximized;
            lstDNAs.DisplayMember = "strDNAme";
            lstDNAs.ContextMenuStrip = cmLstDNA;

        }

        private void mnuCalculateTm_Click(object sender, EventArgs e)
        {

        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            frmDNAmer newFrm = new frmDNAmer(this);
            newFrm.StartPosition = FormStartPosition.CenterScreen;
            newFrm.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuSequenceReverse_Click(object sender, EventArgs e)
        {

        }

        private void lstDNAs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lstDNAs_DoubleClick(object sender, EventArgs e)
        {
            frmDNA temp = (frmDNA)lstDNAs.SelectedItem;
            temp.Activate();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDNA temp  = (frmDNA)lstDNAs.SelectedItem;
            temp.Close();
            lstDNAs.Items.Remove(lstDNAs.SelectedItem);
        }

        private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
