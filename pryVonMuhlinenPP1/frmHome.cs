using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using WpfAnimatedGif;

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
            frmRegisterClients frmNew = new frmRegisterClients();
            frmNew.ShowDialog();
        }

        private void welcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Heladerías Mayo!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void consultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultClients frmNew = new frmConsultClients();
            frmNew.ShowDialog();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegisterSells frmNew = new frmRegisterSells();
            frmNew.ShowDialog();
        }

        private void consultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultSells frmNew = new frmConsultSells();
            frmNew.ShowDialog();
        }

        private void consultByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultSellsByDate frmNew = new frmConsultSellsByDate();
            frmNew.ShowDialog();
        }

        private void consultGraphicSellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChartSells frmNew = new frmChartSells();
            frmNew.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void editSellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void deleteSellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteSells frmNew = new frmDeleteSells();
            frmNew.ShowDialog();
        }

        private void consultToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultProducts frmNew = new frmConsultProducts();
            frmNew.ShowDialog();
        }

        private void registerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRegisterProducts frmNew = new frmRegisterProducts();
            frmNew.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditProducts frmNew = new frmEditProducts();
            frmNew.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteClient frmNew = new frmDeleteClient();
            frmNew.ShowDialog();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteProduct frmNew = new frmDeleteProduct();
            frmNew.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
