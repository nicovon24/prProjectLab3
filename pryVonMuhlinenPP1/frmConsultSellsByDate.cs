using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonMuhlinenPP1
{
    public partial class frmConsultSellsByDate : Form
    {
        public string accessURL = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        public frmConsultSellsByDate()
        {
            InitializeComponent();
            if (grdSells.Rows.Count == 1)
            {
                btnGenerar.Enabled = false;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection dbConnection = new OleDbConnection(accessURL + "BD.mdb");
                dbConnection.Open();

                //getting data from the db
                OleDbCommand bringFromDB = new OleDbCommand("SELECT FechaVenta, COUNT(*) FROM Ventas " +
                    "WHERE FechaVenta >= @StartDate AND FechaVenta <= @EndDate " +
                    "GROUP BY FechaVenta", 
                dbConnection);
                bringFromDB.Parameters.AddWithValue("@StartDate", dtpDate.Value.Date);
                bringFromDB.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);

                //data reading: reading only the data
                OleDbDataReader lectorDeConsulta = bringFromDB.ExecuteReader();

                grdSells.Rows.Clear();
                while (lectorDeConsulta.Read())
                {
                    grdSells.Rows.Add(lectorDeConsulta[0], lectorDeConsulta[1]);
                }

                if(grdSells.Rows.Count == 1) //*siempre tira 1 por defecto, si hay uno está vacío
                {
                    MessageBox.Show("No se han encontrado valores entre ambas fechas");
                }

                dbConnection.Close();

                btnGenerar.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void frmConsultSellsByDate_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmNew = new frmHome();
            frmNew.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            grdSells.Rows.Clear();
            dtpDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (grdSells.Rows.Count > 0)
            {
                //prtVentana: window that appear when we click on btnPrint
                prtVentana.ShowDialog();

                //prtDocument: defines and styles the document we want to print
                prtDocument.PrinterSettings = new PrinterSettings(); //assingning printer to the document
                prtDocument.Print();
                MessageBox.Show("Document printed successfully!");
            }
        }

        private void prtDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            if (grdSells.Rows.Count > 0)
            {
                try
                {
                    //seaching the activity id
                    OleDbConnection conexionDB;
                    conexionDB = new OleDbConnection(accessURL + "BD.mdb");
                    conexionDB.Open();

                    OleDbCommand bringFromDB = new OleDbCommand("SELECT FechaVenta, COUNT(*) FROM Ventas " +
                    "WHERE FechaVenta >= @StartDate AND FechaVenta <= @EndDate " +
                    "GROUP BY FechaVenta",
                    conexionDB);
                    bringFromDB.Parameters.AddWithValue("@StartDate", dtpDate.Value.Date);
                    bringFromDB.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);
                    OleDbDataReader readerClientes = bringFromDB.ExecuteReader();

                    Font font_title = new Font("Arial", 12, FontStyle.Underline); //font of the report
                    Font font_headers = new Font("Arial", 10, FontStyle.Bold); //font of the report
                    Font font_normal = new Font("Arial", 10); //font of the report
                    int y = 100; //eje y position, each time the reader renders a data, we increase the y value so
                    //data will be always below in the docs

                    //headers of each report´s column
                    e.Graphics.DrawString("Fecha", font_title, Brushes.Black, 50, y - 35);
                    e.Graphics.DrawString("Contador", font_headers, Brushes.Black, 50, y - 15);

                    //report table´s content
                    //we do not add barrios, bcs it is not so important
                    while (readerClientes.Read())
                    { //adding data: content, font, color, position in eje x, position in eje y
                        e.Graphics.DrawString(readerClientes[0].ToString(), font_normal, Brushes.Black, 50, y);
                        e.Graphics.DrawString(readerClientes[1].ToString(), font_normal, Brushes.Black, 120, y);
                        y += 15;
                    }
                    readerClientes.Close();
                    conexionDB.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error en la generación del reporte.");
                }
            }
        }
    }
}
