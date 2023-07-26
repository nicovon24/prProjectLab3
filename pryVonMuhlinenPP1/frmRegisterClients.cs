using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
                //validation name and adress
                if (txtName.Text != "" && txtAdress.Text != "")
                {
                    //regex validation
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
                        MessageBox.Show("Client registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbConnection.Close();
                        txtName.Text = ""; txtAdress.Text = ""; txtPhone.Text = "";
                        txtName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Phone must be for example +5493512007668!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("Fill out name and adress, please!", "Missing info!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

        //functions to convert to dollar
        private async Task<string> CallApiAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync("https://api.bluelytics.com.ar/v2/latest");

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        // Handle non-successful responses (e.g., log or show error message)
                        return $"Error: {response.StatusCode}";
                    }
                }
                catch (HttpRequestException ex)
                {
                    // Handle exceptions (e.g., log or show error message)
                    return $"Exception: {ex.Message}";
                }
            }
        }
    }
}
