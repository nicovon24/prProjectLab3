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
        //ClsCombobox ClsCbClient = new ClsCombobox();
        ClsSell ClsNewSell = new ClsSell();
        public frmDeleteSells()
        {
            InitializeComponent();

            //*getting clients comboboxed
            //ClsCbClient.comboBox = cbClient;
            //ClsCbClient.column = "Nombre";
            //ClsCbClient.table = "Clientes";
            //ClsCbClient.ChangeCB();
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
            if (nudIDSells.Text != "0")
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
                    command.Parameters.AddWithValue("@ID", nudIDSells.Text);

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
                        command2.Parameters.AddWithValue("@ID", nudIDSells.Text);

                        OleDbDataReader reader2 = command2.ExecuteReader();
                        MessageBox.Show("Sell deleted");
                        conexionDB.Close();
                        reader.Close();
                        reader2.Close();
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
            OleDbConnection conexionDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb");
            conexionDB.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = conexionDB;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Ventas WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", nudIDSells.Text);

            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                cbExists.Enabled = true;
            }
            else
            {
                cbExists.Enabled = false;
            }

            conexionDB.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
