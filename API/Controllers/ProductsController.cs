using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.OleDb;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly string _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD.mdb";

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        //GET PRODUCT
        [HttpGet(Name = "GetProducts")]
        public List<Products> Get()
        {
            List<Products> productList = new List<Products>();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);
            dbConnection.Open();
            try
            {
                OleDbCommand command = new OleDbCommand("SELECT * FROM Productos");
                command.Connection = dbConnection;

                OleDbDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    Products product = new Products
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Name = reader["Nombre"].ToString(),
                        Price = Convert.ToInt32(reader["Precio"])
                    };

                    productList.Add(product);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error accessing the database: {ex.Message}");
            }

            return productList;
        }


        //DELETE PRODUCT
        [HttpDelete(Name = "DeleteProduct")]
        public IActionResult Delete(string name)
        {
            try
            {
                using (OleDbConnection dbConnection = new OleDbConnection(_connectionString))
                {
                    dbConnection.Open();

                    using (OleDbCommand command = new OleDbCommand("SELECT ID FROM Productos WHERE Nombre = @Name", dbConnection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        int productId = Convert.ToInt32(command.ExecuteScalar());

                        if (productId > 0)
                        {
                            using (OleDbCommand deleteSalesCommand = new OleDbCommand("DELETE FROM Ventas WHERE IDProducto = @ID", dbConnection))
                            {
                                deleteSalesCommand.Parameters.AddWithValue("@ID", productId);
                                deleteSalesCommand.ExecuteNonQuery();
                            }

                            using (OleDbCommand deleteProductCommand = new OleDbCommand("DELETE FROM Productos WHERE ID = @ID", dbConnection))
                            {
                                deleteProductCommand.Parameters.AddWithValue("@ID", productId);
                                deleteProductCommand.ExecuteNonQuery();
                            }
                        }

                        dbConnection.Close();
                    }
                }

                return Ok("Delete successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error accessing the database: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}