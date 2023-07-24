using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.OleDb;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly string _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb";

        //GET PRODUCT
        [HttpGet(Name = "GetEmployee")]
        public List<Employee> Get()
        {
            List<Employee> productList = new List<Employee>();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);
            dbConnection.Open();
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM Empleados");
                command.Connection = dbConnection;

                OleDbDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    Employee employee = new Employee
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["Nombre"].ToString(),
                        Adress = reader["Domicilio"].ToString(),
                        Phone = reader["Teléfono"].ToString(),
                    };

                    productList.Add(employee);
                }
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Error accessing the database: {ex.Message}");
            }

            return productList;
        }
    }
}
