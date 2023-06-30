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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterClients frmNew = new frmRegisterClients();
            frmNew.ShowDialog();
        }

        private void welcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Heladerías Mayo!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void consultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultClients frmNew = new frmConsultClients();
            frmNew.ShowDialog();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterSells frmNew = new frmRegisterSells();
            frmNew.ShowDialog();
        }

        private void consultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultSells frmNew = new frmConsultSells();
            frmNew.ShowDialog();
        }

        private void consultByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultSellsByDate frmNew = new frmConsultSellsByDate();
            frmNew.ShowDialog();
        }

        private void consultGraphicSellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChartSells frmNew = new frmChartSells();
            frmNew.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
