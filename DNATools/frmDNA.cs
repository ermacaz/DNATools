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
    public partial class frmDNA : Form
    {
        public frmDNA()
        {
            InitializeComponent();
            DNA current = new DNA("");
        }

        private void frmDNA_Load(object sender, EventArgs e)
        {

        }
    }
}
