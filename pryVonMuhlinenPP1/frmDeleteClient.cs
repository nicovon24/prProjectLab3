using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonMuhlinenPP1
{
    public partial class frmDeleteClient : Form
    {
        ClsCombobox ClsCbSell = new ClsCombobox();
        public frmDeleteClient()
        {
            InitializeComponent();
            //*getting clients comboboxed
            ClsCbSell.table = "Clientes";
            ClsCbSell.column = "Nombre";
            ClsCbSell.comboBox = cbID;
            ClsCbSell.ChangeCB();
        }

        private void frmDeleteClient_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckData_Click(object sender, EventArgs e)
        {
            if (cbID.Text != "")
            {
                try
                {
                    OleDbConnection conexionDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb");
                    conexionDB.Open();

                    OleDbCommand command = new OleDbCommand();
                    command.Connection = conexionDB;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM Clientes WHERE Nombre = @Nombre";
                    command.Parameters.AddWithValue("@Nombre", cbID.Text);
                    OleDbDataReader reader = command.ExecuteReader();

                    string name = "";

                    //checking product and client data
                    if (reader.Read())
                    {
                        name = reader["Nombre"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Client could not be found");
                    }

                    reader.Close(); 
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
            else
            {
                MessageBox.Show("Data missing");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //*ids que van al form
            if (cbID.Text != "")
            {
                try
                {
                    //searching if ventas id exists
                    OleDbConnection conexionDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb");
                    conexionDB.Open();

                    OleDbCommand command = new OleDbCommand();
                    command.Connection = conexionDB;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM Clientes WHERE Nombre = @Nombre";
                    command.Parameters.AddWithValue("@Nombre", cbID.Text);

                    OleDbDataReader reader = command.ExecuteReader();

                    //*deleting existing ventas item with x id
                    if (reader.Read())
                    {
                        //before deleting the client, we have to delete all records from sells which are linked with the user
                        OleDbCommand commandDeleteFromVentas = new OleDbCommand();
                        commandDeleteFromVentas.Connection = conexionDB;
                        commandDeleteFromVentas.CommandType = CommandType.Text;
                        commandDeleteFromVentas.CommandText = "DELETE FROM Ventas WHERE IDCliente = @ID";
                        commandDeleteFromVentas.Parameters.AddWithValue("@ID", reader["ID"]);
                        commandDeleteFromVentas.ExecuteNonQuery();


                        //deleting the client
                        OleDbCommand commandDeleteClient = new OleDbCommand();
                        commandDeleteClient.Connection = conexionDB;
                        commandDeleteClient.CommandType = CommandType.Text;
                        commandDeleteClient.CommandText = "DELETE FROM Clientes WHERE Nombre = @ID";
                        commandDeleteClient.Parameters.AddWithValue("@ID", cbID.Text);
                        OleDbDataReader reader2 = commandDeleteClient.ExecuteReader();

                        //extras
                        MessageBox.Show("Client deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexionDB.Close();
                        reader.Close();
                        reader2.Close();
                        ClsCbSell.table = "Clientes";
                        ClsCbSell.column = "Nombre";
                        cbID.Text = "";

                        ClsCbSell.comboBox = cbID;
                        cbID.Items.Clear();
                        ClsCbSell.ChangeCB();
                    }
                    else
                    {
                        MessageBox.Show("Sell could not be found", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
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

