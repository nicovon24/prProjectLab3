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
    public partial class frmDeleteProduct : Form
    {
        ClsCombobox ClsCbSell = new ClsCombobox();
        public frmDeleteProduct()
        {
            InitializeComponent();
            //*getting clients comboboxed
            ClsCbSell.table = "Productos";
            ClsCbSell.column = "Nombre";
            ClsCbSell.comboBox = cbID;
            ClsCbSell.ChangeCB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
                    command.CommandText = "SELECT * FROM Productos WHERE Nombre = @ID";
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
                        command2.CommandText = "DELETE FROM Ventas WHERE IDProducto = @ID";
                        command2.Parameters.AddWithValue("@ID", reader["ID"]);

                        OleDbDataReader reader2 = command2.ExecuteReader();

                        OleDbConnection conexionDB3 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb");
                        conexionDB3.Open();

                        OleDbCommand command3 = new OleDbCommand();
                        command3.Connection = conexionDB;
                        command3.CommandType = CommandType.Text;
                        command3.CommandText = "DELETE FROM Productos WHERE ID = @ID";
                        command3.Parameters.AddWithValue("@ID", reader["ID"]);

                        command3.ExecuteNonQuery();

                        MessageBox.Show("Sell deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conexionDB.Close();
                        reader.Close();
                        reader2.Close();
                        ClsCbSell.table = "Productos";
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
            else
            {
                MessageBox.Show("Data missing");
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
