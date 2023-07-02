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
    public partial class frmConsultSells : Form
    {

        public string accessURL = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";

        ClsCombobox ClsCbEmployee = new ClsCombobox();

        ClsSell ClsNewSell = new ClsSell();


        public frmConsultSells()
        {
            InitializeComponent();

            //*getting COMBOBOXES
            ClsCbEmployee.comboBox = cbEmployee;
            ClsCbEmployee.column = "Nombre";
            ClsCbEmployee.table = "Empleados";
            ClsCbEmployee.ChangeCB();

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

                int income = ClsNewSell.FillGrid(); //*calling the method grid

                btnIncome.Text = $"${income}";

                lectorSells.Close();
                dbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void frmConsultSells_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmNew = new frmHome();
            frmNew.ShowDialog();
        }

        private void grdSells_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int IDEmployee = ClsCbEmployee.GetIDForFormulare(cbEmployee.Text.ToString());

            try
            {
                OleDbConnection dbConnection = new OleDbConnection(accessURL + "BD.mdb");
                dbConnection.Open();

                //getting data from the db
                OleDbCommand bringFromDB = new OleDbCommand();

                //*converting it in format sql
                DateTime dateValue = dtpDate.Value.Date;
                string formattedDate = dateValue.ToString("dd/MM/yyyy");

                //*command and parameters
                OleDbCommand commandResult = new OleDbCommand();
                commandResult.Connection = dbConnection;

                bool valid = false;

               
                //*error if none of them are checked
                if(cbxAllowDate.Checked==true || cbxAllowEmployee.Checked == true)
                {
                    //*if both are checked, we filter depending on both
                    if (cbxAllowDate.Checked == true && cbxAllowEmployee.Checked == true)
                    {
                        if (cbEmployee.Text!="")
                        {
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Ventas WHERE IDEmpleado = @IDEmpleado AND FechaVenta >= @StartDate AND FechaVenta <= @EndDate", dbConnection
                            );
                            command.Parameters.AddWithValue("@IDEmpleado", IDEmployee);
                            command.Parameters.AddWithValue("@StartDate", dtpDate.Value.Date);
                            command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);
                            commandResult = command;
                            valid = true;
                        }
                        else
                        {
                            MessageBox.Show("Fill the employee field, please");
                        }
                    }

                    //*date checkbox only checked
                    else if (cbxAllowDate.Checked == true && cbxAllowEmployee.Checked == false)
                    {
                        OleDbCommand command = new OleDbCommand("SELECT * FROM Ventas WHERE FechaVenta >= @StartDate AND FechaVenta <= @EndDate", dbConnection
                        );
                        command.Parameters.AddWithValue("@StartDate", dtpDate.Value.Date);
                        command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);
                        commandResult = command;
                        valid = true;
                    }

                    //*employee checkbox only checked
                    else if (cbxAllowDate.Checked == false && cbxAllowEmployee.Checked == true)
                    {
                        if (cbEmployee.Text != "")
                        {
                            OleDbCommand command = new OleDbCommand("SELECT * FROM Ventas WHERE IDEmpleado = @IDEmpleado", dbConnection
                            );
                            command.Parameters.AddWithValue("@IDEmpleado", IDEmployee);
                            commandResult = command;
                            valid = true;
                        }
                        else
                        {
                            MessageBox.Show("Fill the employee field, please");
                        }
                    }

                    //filling the grid
                    if (valid == true)
                    {
                        OleDbDataReader lectorDeConsulta = commandResult.ExecuteReader();

                        grdSells.Rows.Clear();

                        ClsSell ClsNewSell2 = new ClsSell();
                        ClsNewSell2.grdSells = grdSells;
                        ClsNewSell2.lectorSells = lectorDeConsulta;
                        ClsNewSell2.lblCounterRes = lblCounterRes;

                        int income = ClsNewSell2.FillGrid();

                        btnIncome.Text = $"${income}";

                        lectorDeConsulta.Close();
                    }
                }
                else
                {
                    MessageBox.Show("You have not marked any filter, try again!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void cbxAllowEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAllowEmployee.Checked == true)
            {
                cbEmployee.Enabled = true;
            }
            else
            {
                cbEmployee.Enabled = false;
            }
        }

        private void cbxAllowDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAllowDate.Checked == true)
            {
                dtpDate.Enabled = true;
                dtpEndDate.Enabled = true;
            }
            else
            {
                dtpDate.Enabled = false;
                dtpEndDate.Enabled = false;
            }
        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCounterRes_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbEmployee.Text = "";
            dtpDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            grdSells.Rows.Clear();
            int income = ClsNewSell.getInitialGrid();
            btnIncome.Text = $"${income}";
        }
    }
}
