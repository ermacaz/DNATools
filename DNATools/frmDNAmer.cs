using System;
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
    public partial class frmDNAmer : Form
    {
        private string strDNAme;
        public frmMain frmMaster;
        public frmDNAmer(frmMain frmParent)
        {
            InitializeComponent();
            frmMaster = frmParent;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            strDNAme = txtName.Text;
            frmDNA newDNAFrm = new frmDNA(frmMaster, strDNAme);
            newDNAFrm.MdiParent = frmMaster;
            newDNAFrm.Show();
            this.Close();
        }

        public override string ToString()
        {
            return strDNAme;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }


    }
}
