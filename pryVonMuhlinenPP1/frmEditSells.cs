using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonMuhlinenPP1
{
    public partial class frmEditSells : Form
    {
        public frmEditSells()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmNew = new frmHome();
            frmNew.ShowDialog();
        }
    }
}
