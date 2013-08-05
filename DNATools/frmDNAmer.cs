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
        public frmDNAmer()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmDNA newDNAFrm = new frmDNA(txtName.Text);
            newDNAFrm.MdiParent = this.MdiParent;
            newDNAFrm.Show();
            this.Close();
        }

       
    }
}
