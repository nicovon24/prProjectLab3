using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonMuhlinenPP1
{
    internal class ClsConsult
    {
        public string  accessURL = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        public string Table;
        public int NumCols;
        public DataGridView grd;
        public Button lbl;

        public void ConsultFillGrid()
        {
            try
            {
                OleDbConnection dbConnection = new OleDbConnection(this.accessURL + "BD.mdb");
                dbConnection.Open();

                //getting data from the db
                OleDbCommand bringFromDB = new OleDbCommand();

                bringFromDB.Connection = dbConnection; //connecting .net with the DB
                bringFromDB.CommandType = CommandType.TableDirect; //getting the data from a table
                bringFromDB.CommandText = this.Table
                    //"Clientes"
                    ; //name of the table

                //data reading: reading only the data
                OleDbDataReader lectorDeConsulta = bringFromDB.ExecuteReader();

                //we add the data to the grdClients
                while (lectorDeConsulta.Read())
                {
                    if(NumCols==2) grd.Rows.Add(lectorDeConsulta[1], lectorDeConsulta[2]);
                    else if(NumCols==3) grd.Rows.Add(lectorDeConsulta[1], lectorDeConsulta[2], lectorDeConsulta[3]);
                    else if (NumCols == 5) grd.Rows.Add(lectorDeConsulta[1], lectorDeConsulta[2], lectorDeConsulta[3], lectorDeConsulta[4], lectorDeConsulta[5]);
                }

                if (NumCols == 5)
                {
                    ClsSell ClsNewSell = new ClsSell();

                    ClsNewSell.grdSells = grd;
                    ClsNewSell.lectorSells = lectorDeConsulta;
                    ClsNewSell.lblCounterRes = lbl;

                    ClsNewSell.FillGrid();
                }

                dbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
