using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.OleDb;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly string _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb";

        //GET PRODUCT
        [HttpGet(Name = "GetClient")]
        public List<Clients> Get()
        {
            List<Clients> employeeList = new List<Clients>();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);
            dbConnection.Open();
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM Clientes");
                command.Connection = dbConnection;

                OleDbDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    Clients client = new Clients
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["Nombre"].ToString(),
                        Adress = reader["Domicilio"].ToString(),
                        Phone = reader["Teléfono"].ToString(),
                    };

                    employeeList.Add(client);
                }
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Error accessing the database: {ex.Message}");
            }

            return employeeList;
        }
    }
}
