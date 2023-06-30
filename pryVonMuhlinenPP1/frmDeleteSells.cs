using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonMuhlinenPP1
{
    public partial class frmDeleteSells : Form
    {
        ClsCombobox ClsCbSell = new ClsCombobox();
        public frmDeleteSells()
        {
            InitializeComponent();

            //*getting clients comboboxed
            ClsCbSell.table = "Ventas";
            ClsCbSell.column = "ID";
            ClsCbSell.comboBox = cbID;
            ClsCbSell.ChangeCB();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmNew = new frmHome();
            frmNew.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    command.CommandText = "SELECT * FROM Ventas WHERE ID = @ID";
                    command.Parameters.AddWithValue("@ID", cbID.Text);

                    OleDbDataReader reader = command.ExecuteReader();

                    //*deleting existing ventas item with x id
                    if (reader.Read())
                    {
                        OleDbConnection conexionDB2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb");
                        conexionDB2.Open();

                        OleDbCommand command2 = new OleDbCommand();
                        command2.Connection = conexionDB;
                        command2.CommandType = CommandType.Text;
                        command2.CommandText = "DELETE FROM Ventas WHERE ID = @ID";
                        command2.Parameters.AddWithValue("@ID", cbID.Text);

                        OleDbDataReader reader2 = command2.ExecuteReader();
                        MessageBox.Show("Sell deleted");
                        conexionDB.Close();
                        reader.Close();
                        reader2.Close();
                        ClsCbSell.table = "Ventas";
                        ClsCbSell.column = "ID";
                        ClsCbSell.comboBox = cbID;
                        cbID.Items.Clear();
                        cbID.Text = "";
                        ClsCbSell.ChangeCB();
                    }
                    else
                    {
                        MessageBox.Show("Sell could not be found");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        private void frmDeleteSells_Load(object sender, EventArgs e)
        {

        }

        private void nudIDSells_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        //checking data for id
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
                    command.CommandText = "SELECT * FROM Ventas WHERE ID = @ID";
                    command.Parameters.AddWithValue("@ID", cbID.Text);

                    OleDbDataReader reader = command.ExecuteReader();

                    int idProduct = 0, idClient = 0;
                    bool foundData = false;

                    //checking product and client data
                    if (reader.Read())
                    {
                        idProduct = int.Parse(reader["IDProducto"].ToString());
                        idClient = int.Parse(reader["IDCliente"].ToString());
                        foundData = true;
                    }
                    else
                    {
                        MessageBox.Show("Sell could not be found");
                    }

                    reader.Close();

                    if (foundData == true)
                    {
                        //GETTING PRODUCT NAME
                        OleDbCommand commandProduct = new OleDbCommand();
                        commandProduct.Connection = conexionDB;
                        commandProduct.CommandType = CommandType.Text;
                        commandProduct.CommandText = "SELECT * FROM Productos WHERE ID = @ID";
                        commandProduct.Parameters.AddWithValue("@ID", idProduct);

                        OleDbDataReader readerProduct = commandProduct.ExecuteReader();

                        if (readerProduct.Read())
                        {
                            lblProductRes.Text = readerProduct["Nombre"].ToString();
                        }

                        readerProduct.Close(); 


                    }
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
    }
}
