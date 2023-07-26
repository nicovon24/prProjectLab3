using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryVonMuhlinenPP1
{
    public partial class frmChartSells : Form
    {
        public frmChartSells()
        {
            InitializeComponent();

            //chartBindSource.DataSource = new List<ClsGetCharts>();

            chrtSells.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" },
                LabelsRotation = 15,
                Width = 20 // Adjust the width value as needed
            });

            OleDbConnection dbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb");
            dbConnection.Open();

            //getting data from the db
            //OleDbCommand numberOfSellsFromDB = new OleDbCommand("SELECT MonthOfTheYear, COUNT(*) AS TotalCount " +
            //                                "FROM (SELECT MONTH(FechaVenta) AS MonthOfTheYear FROM Ventas) AS Subquery " +
            //                                "GROUP BY MonthOfTheYear",
            //                                dbConnection);

            OleDbCommand sellsFromDB = new OleDbCommand("SELECT MonthOfTheYear, SUM(p.Precio) AS TotalPrice " +
                                            "FROM (SELECT MONTH(FechaVenta) AS MonthOfTheYear, IDProducto FROM Ventas) AS Subquery " +
                                            "INNER JOIN Productos AS p ON Subquery.IDProducto = p.ID " +
                                            "GROUP BY MonthOfTheYear",
                                            dbConnection);

            //data reading: reading only the data
            OleDbDataReader lectorDeConsulta = sellsFromDB.ExecuteReader();

            ChartValues<int> arr = new ChartValues<int>();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            while (lectorDeConsulta.Read())
            {
                myDictionary.Add(lectorDeConsulta[0].ToString(), int.Parse(lectorDeConsulta[1].ToString()));
                int value = Convert.ToInt32(lectorDeConsulta[1]);
                //arr.Add(value);
            }

            Dictionary<string, string> dictionaryMonths = new Dictionary<string, string>();
            dictionaryMonths.Add("1", "January");
            dictionaryMonths.Add("2", "February");
            dictionaryMonths.Add("3", "March");
            dictionaryMonths.Add("4", "April");
            dictionaryMonths.Add("5", "May");
            dictionaryMonths.Add("6", "June");
            dictionaryMonths.Add("7", "July");
            dictionaryMonths.Add("8", "August");
            dictionaryMonths.Add("9", "September");
            dictionaryMonths.Add("10", "October");
            dictionaryMonths.Add("11", "November");
            dictionaryMonths.Add("12", "December");

            int i = 1;

            int j = 0;
            foreach (var month in dictionaryMonths.Keys)
            {
                bool flag = false;
                foreach (var key in myDictionary.Keys)
                {
                    if (month == key)
                    {
                        arr.Add(myDictionary[key.ToString()]);
                        flag = true;
                    }
                    j++;
                }
                if (flag == false)
                {
                    arr.Add(0);
                }
                j = 0;
                i++;
            }


            var columnSeries = new LiveCharts.Wpf.ColumnSeries
            {
                Values = arr,
                //MaxColumnWidth = 23 // Adjust the column width value as needed
            };

            chrtSells.Series.Add(columnSeries);
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void frmChartSells_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
