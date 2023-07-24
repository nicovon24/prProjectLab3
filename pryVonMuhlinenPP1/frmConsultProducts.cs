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
    public partial class frmConsultProducts : Form
    {
        public string accessURL = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        public frmConsultProducts()
        {
            InitializeComponent();
            ClsConsult cls = new ClsConsult();
            cls.Table = "Productos";
            cls.NumCols = 2;
            cls.grd = grdProducts;
            cls.ConsultFillGrid();

            //try
            //{
            //    OleDbConnection dbConnection = new OleDbConnection(accessURL + "BD.mdb");
            //        dbConnection.Open();

            //    //getting data from the db
            //    OleDbCommand bringFromDB = new OleDbCommand();

            //    bringFromDB.Connection = dbConnection; //connecting .net with the DB
            //    bringFromDB.CommandType = CommandType.TableDirect; //getting the data from a table
            //    bringFromDB.CommandText = "Productos"; //name of the table

            //    //data reading: reading only the data
            //    OleDbDataReader lectorDeConsulta = bringFromDB.ExecuteReader();

            //    //we add the data to the grdClients
            //    while (lectorDeConsulta.Read())
            //    {
            //        grdProducts.Rows.Add(lectorDeConsulta[1], $"${lectorDeConsulta[2]}");
            //    }

            //    dbConnection.Close();
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.ToString());
            //}

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmNew = new frmHome();
            frmNew.ShowDialog();
        }

        private void frmConsultProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
