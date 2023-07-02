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
using System.Xml.Linq;

namespace pryVonMuhlinenPP1
{
    public partial class frmEditProducts : Form
    {
        ClsCombobox ClsCbSell = new ClsCombobox();

        //to compare with editable data
        string initialName = "";
        int initialPrice = 0;
        public frmEditProducts()
        {
            InitializeComponent();
            //*getting clients comboboxed
            ClsCbSell.table = "Productos";
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

        private void frmEditProducts_Load(object sender, EventArgs e)
        {

        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
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
                    command.CommandText = "SELECT * FROM Productos WHERE ID = @ID";
                    command.Parameters.AddWithValue("@ID", cbID.Text);

                    OleDbDataReader reader = command.ExecuteReader();

                    //*deleting existing ventas item with x id
                    if (reader.Read())
                    {
                        string name = reader["Nombre"].ToString();
                        int price = int.Parse(reader["Precio"].ToString());

                        txtName.Text = name;
                        nudPrice.Value = price;

                        //to compare with the editable data
                        initialName = name;
                        initialPrice = price;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(initialName!=txtName.Text || initialPrice != int.Parse(nudPrice.Text))
            {
                MessageBox.Show("Data edited", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("None data edited", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
