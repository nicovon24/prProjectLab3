using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.OleDb;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly string _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb";

        //public SellController(ILogger<SellController> logger)
        //{
        //    _logger = logger;
        //}

        //GET PRODUCT
        [HttpGet(Name = "GetSells")]
        public List<Sells> Get()
        {
            List<Sells> productList = new List<Sells>();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);
            dbConnection.Open();
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM Ventas");
                command.Connection = dbConnection;

                OleDbDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    DateTime fechaVenta = Convert.ToDateTime(reader["FechaVenta"]).Date;
                    string fechaVentaString = fechaVenta.ToString("dd/MM/yyyy");

                    Sells product = new Sells
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        IDProducto = Convert.ToInt32(reader["IDProducto"]),
                        IDCliente = Convert.ToInt32(reader["IDCliente"]),
                        IDEmpleado = Convert.ToInt32(reader["IDEmpleado"]),
                        FechaVenta = fechaVentaString,
                        HoraVenta = reader["HoraVenta"].ToString(),
                    };

                    productList.Add(product);
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
