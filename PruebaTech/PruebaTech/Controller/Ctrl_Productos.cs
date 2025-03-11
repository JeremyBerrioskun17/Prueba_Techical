using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTech.Models;

namespace PruebaTech.Controller
{
    class Ctrl_Productos
    {
        public List<Productos> Cargar_Productos()
        {
            List<Productos> listaProductos = new List<Productos>();
            string SQL = "SELECT * FROM Producto";

            // Usamos 'using' para asegurarnos de que la conexión se cierra automáticamente
            using (SqlConnection conexionDB = Conexion.conexion())
            {
                // Verificamos si la conexión fue exitosa
                if (conexionDB != null)
                {
                    try
                    {
                        conexionDB.Open();  // Abrimos la conexión

                        SqlCommand comando = new SqlCommand(SQL, conexionDB);
                        SqlDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            Productos producto = new Productos()
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                Cantidad = Convert.ToInt32(reader["CantidadEnStock"])
                            };
                            listaProductos.Add(producto);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("No se pudo establecer la conexión.");
                }
            }

            return listaProductos;
        }


        public bool AgregarProducto(string nombre, string descripcion, decimal precio, int cantidadEnStock)
        {
            bool resultado = false;
            string SQL = "EXEC CrearProducto @Nombre, @Descripcion, @Precio, @CantidadEnStock";

            // Usar 'using' para asegurar que la conexión se cierra automáticamente
            using (SqlConnection conexionDB = Conexion.conexion())
            {
                if (conexionDB != null)
                {
                    try
                    {
                        conexionDB.Open();  // Abrir la conexión

                        SqlCommand comando = new SqlCommand(SQL, conexionDB);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Descripcion", descripcion ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@Precio", precio);
                        comando.Parameters.AddWithValue("@CantidadEnStock", cantidadEnStock);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("No se pudo establecer la conexión.");
                }
            }

            return resultado;
        }

        public bool ActualizarProducto(int idProducto, string nombre, string descripcion, decimal precio, int cantidadEnStock)
        {
            bool resultado = false;
            string SQL = "EXEC ActualizarProducto @IdProducto, @Nombre, @Descripcion, @Precio, @CantidadEnStock";

            // Usar 'using' para asegurar que la conexión se cierra automáticamente
            using (SqlConnection conexionDB = Conexion.conexion())
            {
                if (conexionDB != null)
                {
                    try
                    {
                        conexionDB.Open();  // Abrir la conexión

                        SqlCommand comando = new SqlCommand(SQL, conexionDB);
                        comando.Parameters.AddWithValue("@IdProducto", idProducto);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Descripcion", descripcion ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@Precio", precio);
                        comando.Parameters.AddWithValue("@CantidadEnStock", cantidadEnStock);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("No se pudo establecer la conexión.");
                }
            }

            return resultado;
        }

        public bool EliminarProducto(int idProducto)
        {
            bool resultado = false;
            string SQL = "EXEC EliminarProducto @IdProducto";

            // Usar 'using' para asegurar que la conexión se cierra automáticamente
            using (SqlConnection conexionDB = Conexion.conexion())
            {
                if (conexionDB != null)
                {
                    try
                    {
                        conexionDB.Open();  // Abrir la conexión

                        SqlCommand comando = new SqlCommand(SQL, conexionDB);
                        comando.Parameters.AddWithValue("@IdProducto", idProducto);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("No se pudo establecer la conexión.");
                }
            }

            return resultado;
        }
    }
}
