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
    public partial class frmRegisterSells : Form
    {
        //for comboboxed
        ClsCombobox ClsCbClient = new ClsCombobox();
        ClsCombobox ClsCbProducts = new ClsCombobox();
        ClsCombobox ClsCbEmployees = new ClsCombobox();
        public frmRegisterSells()
        {
            InitializeComponent();

            //*getting clients comboboxed
            ClsCbClient.comboBox = cbClient;
            ClsCbClient.column = "Nombre";
            ClsCbClient.table = "Clientes";
            ClsCbClient.ChangeCB();

            //*getting products comboboxed
            ClsCbProducts.comboBox = cbProduct;
            ClsCbProducts.column = "Nombre";
            ClsCbProducts.table = "Productos";
            ClsCbProducts.ChangeCB();

            //*getting employees comboboxed
            ClsCbEmployees.comboBox= cbEmployee;
            ClsCbEmployees.column = "Nombre";
            ClsCbEmployees.table = "Empleados";
            ClsCbEmployees.ChangeCB();
        }

        private void frmRegisterSells_Load(object sender, EventArgs e)
        {


        }

        //*btn register
        private void button1_Click(object sender, EventArgs e)
        {
            //*ids que van al form
            try
            {
                //ids
                int IDClient = ClsCbClient.GetIDForFormulare(cbClient.Text.ToString());
                int IDEmployee = ClsCbEmployees.GetIDForFormulare(cbEmployee.Text.ToString());
                int IDProduct = ClsCbProducts.GetIDForFormulare(cbProduct.Text.ToString());
                
                //date and time
                string day = dtpDate.Value.Day.ToString();
                string month = dtpDate.Value.Month.ToString();
                string year = dtpDate.Value.Year.ToString();
                string hour = dtpDate.Value.Hour.ToString();
                string minute = dtpDate.Value.Minute.ToString();
                string date = day + "/" + month + "/" + year;
                string time = hour + ":" + minute;

                DateTime dateForDB = new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));

                //validation
                if (IDClient != 0 && IDEmployee.ToString() != "" && IDProduct != 0 && date != "")
                {
                    OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD.mdb");
                    dbConnection.Open();

                    //we execute this code if the numLibro is not in the access file
                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = dbConnection;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO VENTAS (IDProducto, IDCliente, IDEmpleado, HoraVenta, FechaVenta)" +
                    " VALUES('" + IDProduct + "','" + IDClient + "','" + IDEmployee + "','" + time + "','" + dateForDB + "')";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Sell registered");
                    dbConnection.Close();
                    cbClient.Text = ""; cbEmployee.Text = ""; cbProduct.Text = "";
                    cbClient.Focus();
                }

                else
                {
                    MessageBox.Show("¡Mal!");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
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
