using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //
using System.Data.Common;
using System.Net;
using System.IO;

namespace pryVonMuhlinenPP1
{
    public partial class frmConsultClients : Form
    {
        public string accessURL = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        public frmConsultClients()
        {
            InitializeComponent();
            ClsConsult cls = new ClsConsult();
            cls.Table = "Clientes";
            cls.NumCols = 3;
            cls.grd = grdClients;
            cls.ConsultFillGrid();

            //try
            //{
            //    OleDbConnection dbConnection = new OleDbConnection(accessURL + "BD.mdb");
            //    dbConnection.Open();

            //    //getting data from the db
            //    OleDbCommand bringFromDB = new OleDbCommand();

            //    bringFromDB.Connection = dbConnection; //connecting .net with the DB
            //    bringFromDB.CommandType = CommandType.TableDirect; //getting the data from a table
            //    bringFromDB.CommandText = "Clientes"; //name of the table

            //    //data reading: reading only the data
            //    OleDbDataReader lectorDeConsulta = bringFromDB.ExecuteReader();

            //    //we add the data to the grdClients
            //    while (lectorDeConsulta.Read())
            //    {
            //        grdClients.Rows.Add(lectorDeConsulta[1], lectorDeConsulta[2], lectorDeConsulta[3]);
            //    }

            //    dbConnection.Close();
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.ToString());
            //}
        }

            private void frmConsultClients_Load(object sender, EventArgs e)
        {

        }

        private void dtgClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "C:\\";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.FileName = "clients.txt";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result.ToString() == "OK")
            {
                string selectedFileName = saveFileDialog.FileName;
                StreamWriter writer = new StreamWriter(selectedFileName);
                OleDbConnection dbConnection = new OleDbConnection(accessURL + "BD.mdb");
                dbConnection.Open();

                //getting data from the db
                OleDbCommand bringFromDB = new OleDbCommand();

                bringFromDB.Connection = dbConnection; //connecting .net with the DB
                bringFromDB.CommandType = CommandType.TableDirect; //getting the data from a table
                bringFromDB.CommandText = "Clientes"; //name of the table

                //data reading: reading only the data
                OleDbDataReader reader = bringFromDB.ExecuteReader();

                writer.Write("ID, Name, Adress, Phone");
                writer.WriteLine();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        writer.Write(reader[i].ToString() + ", ");
                    }
                    writer.WriteLine();
                }
                reader.Close();
                writer.Close();
                dbConnection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
