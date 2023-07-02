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
    internal class ClsSell
    {
        public string accessURL = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        public DataGridView grdSells;
        public OleDbDataReader lectorSells;
        public Button lblCounterRes;

        public int FillGrid()
        {
            //*getting product name

            OleDbConnection conexionDB = new OleDbConnection(accessURL + "BD.mdb");
            conexionDB.Open();
            int counter = 0;
            int totalIncome = 0;

            while (lectorSells.Read())
            {

                conexionDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb");
                conexionDB.Open();

                OleDbCommand bringProducts = new OleDbCommand();

                bringProducts.Connection = conexionDB; //connecting .net with the DB
                bringProducts.CommandType = CommandType.TableDirect; //getting the data from a table
                bringProducts.CommandText = "Productos"; //name of the table


                OleDbDataReader lectorProducts = bringProducts.ExecuteReader();

                string producto = "";
                int price = 0;

                while (lectorProducts.Read())
                {

                    if (lectorProducts["ID"].ToString() == lectorSells["IDProducto"].ToString())
                    {
                        producto = lectorProducts["Nombre"].ToString();
                        price = int.Parse(lectorProducts["Precio"].ToString());
                        totalIncome += price;
                    }
                }

                lectorProducts.Close();


                //*getting client name

                OleDbCommand bringClients = new OleDbCommand();

                bringClients.Connection = conexionDB; //connecting .net with the DB
                bringClients.CommandType = CommandType.TableDirect; //getting the data from a table
                bringClients.CommandText = "Clientes"; //name of the table

                OleDbDataReader lectorClients = bringClients.ExecuteReader();

                string client = "";

                while (lectorClients.Read())
                {

                    if (lectorClients["ID"].ToString() == lectorSells["IDCliente"].ToString())
                    {
                        client = lectorClients["Nombre"].ToString();
                    }
                }

                DateTime date = lectorSells.GetDateTime(lectorSells.GetOrdinal("FechaVenta"));

                string day = date.Day.ToString();
                string month = date.Month.ToString();
                string year = date.Year.ToString();
                string hour = date.Hour.ToString();
                string minute = date.Minute.ToString();
                string dateFinal = day + "/" + month + "/" + year;
                string timeFinal = "";

                if (Int32.Parse(hour) < 10) { timeFinal += "0" + hour + ":"; }
                else { timeFinal += hour + ":"; }

                if (Int32.Parse(minute) < 10) { timeFinal += "0" + minute; }
                else { timeFinal += minute; }

                grdSells.Rows.Add(producto, client, dateFinal, timeFinal, $"${price}");

                lectorClients.Close();

                counter++;
            }

            lblCounterRes.Text = counter.ToString();

            conexionDB.Close();

            return totalIncome;
        }

        public int getInitialGrid()
        {
            grdSells.Rows.Clear();

            string accessURL = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";

            ClsCombobox ClsCbEmployee = new ClsCombobox();

            ClsSell ClsNewSell = new ClsSell();

            try
            {
                //*getting CONSULT data
                OleDbConnection dbConnection = new OleDbConnection(accessURL + "BD.mdb");
                dbConnection.Open();

                //getting data from the db
                OleDbCommand bringSells = new OleDbCommand();

                bringSells.Connection = dbConnection; //connecting .net with the DB
                bringSells.CommandType = CommandType.TableDirect; //getting the data from a table
                bringSells.CommandText = "Ventas"; //name of the table

                //data reading: reading only the data
                OleDbDataReader lectorSells = bringSells.ExecuteReader();

                ClsNewSell.grdSells = grdSells;
                ClsNewSell.lectorSells = lectorSells;
                ClsNewSell.lblCounterRes = lblCounterRes;

                int price = ClsNewSell.FillGrid(); //*calling the method grid

                lectorSells.Close();
                dbConnection.Close();

                return price;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return 0;
            }
        }

        //public int getClient(string name){
        //    try
        //    {
        //        int id = 0;

        //        OleDbConnection conexionDB;

        //        conexionDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb");
        //        conexionDB.Open();

        //        OleDbCommand command = new OleDbCommand();

        //        command.Connection = conexionDB;
        //        command.CommandType = CommandType.TableDirect;
        //        command.CommandText = "Clientes";

        //        OleDbDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            if (reader["Nombre"].ToString() == name)
        //            {
        //                id = int.Parse(reader["ID"].ToString());
        //            }
        //        }
        //        conexionDB.Close();
        //        reader.Close();

        //        return id;
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show(err.ToString());

        //        return 0;
        //    }
        //}
    }
    
}
