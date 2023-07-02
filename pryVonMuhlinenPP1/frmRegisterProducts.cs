using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonMuhlinenPP1
{
    public partial class frmRegisterProducts : Form
    {
        public frmRegisterProducts()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmNew = new frmHome();
            frmNew.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //validation name and adress
                if (txtName.Text != "" && nudPrice.Text != "0")
                {
                    //regex validation
                        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD.mdb");
                        dbConnection.Open();

                        //we execute this code if the numLibro is not in the access file
                        OleDbCommand comando = new OleDbCommand();
                        comando.Connection = dbConnection;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "INSERT INTO Productos (Nombre, Precio)" +
                        " VALUES('" + txtName.Text + "'," + int.Parse(nudPrice.Value.ToString()) + ")";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Product registered");
                        dbConnection.Close();
                        txtName.Text = ""; nudPrice.Text = "0";
                        txtName.Focus();
                }
                else
                {
                    MessageBox.Show("Fill out name and adress, please!", "Missing info!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
