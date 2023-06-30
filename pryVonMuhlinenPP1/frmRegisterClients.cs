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
    public partial class frmRegisterClients : Form
    {
        string regexPhone = @"^\+?(\d{1,3})?[-.\s]?\(?(11|\d{2})\)?[-.\s]?(\d{4})[-.\s]?(\d{4})$"; //ex: +54 9 11 1234-5678;

        public frmRegisterClients()
        {
            InitializeComponent();
        }

        private void frmRegisterClients_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtAdress.Text != "")
                {
                    if (Regex.IsMatch(txtPhone.Text, regexPhone))
                    {
                        OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD.mdb");
                        dbConnection.Open();

                        string varName = txtName.Text, varAdress = txtAdress.Text, varPhone = txtPhone.Text;

                        //we execute this code if the numLibro is not in the access file
                        OleDbCommand comando = new OleDbCommand();
                        comando.Connection = dbConnection;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "INSERT INTO CLIENTES (Nombre, Domicilio, Teléfono)" +
                        " VALUES('" + varName + "','" + varAdress + "','" + varPhone + "')";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Client registered");
                        dbConnection.Close();
                        txtName.Text = ""; txtAdress.Text = ""; txtPhone.Text = "";
                        txtName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Phone must be for example +5493512007668!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmNew = new frmHome();
            frmNew.ShowDialog();
        }
    }
}
