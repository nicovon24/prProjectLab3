using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryVonMuhlinenPP1
{
    internal class ClsCombobox
    {
        public string table;
        public string column;
        public System.Windows.Forms.ComboBox comboBox;

        public void ChangeCB()
        {
            try
            {
                OleDbConnection conexionDB;

                conexionDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb");
                conexionDB.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = conexionDB;
                command.CommandType = CommandType.TableDirect;
                command.CommandText = "SELECT * FROM " + this.table + " ORDER BY " + this.column;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    this.comboBox.Items.Add(reader[this.column].ToString());
                }

                conexionDB.Close();
                reader.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public int GetIDForFormulare(string input)
        {
            try
            {
                int id = 0;

                OleDbConnection conexionDB;

                conexionDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb");
                conexionDB.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = conexionDB;
                command.CommandType = CommandType.TableDirect;
                command.CommandText = this.table;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[this.column].ToString() == input)
                    {
                        id = int.Parse(reader["ID"].ToString());
                    }
                }
                conexionDB.Close();
                reader.Close();

                return id;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());

                return 0;
            }
        }
    }
}
