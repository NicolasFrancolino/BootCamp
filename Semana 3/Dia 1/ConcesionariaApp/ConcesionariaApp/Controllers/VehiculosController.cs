using ConcesionariaApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConcesionariaApp.Controllers
{
    public class VehiculosController : Controller
    {
        private static string connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        private List<Vehiculo> lista = new List<Vehiculo>();
        // GET: Vehiculos
        public ActionResult Index()
        {
            using (SqlConnection connectDataBase = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM VEHICULO", connectDataBase);
                command.CommandType = System.Data.CommandType.Text;
                connectDataBase.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        Vehiculo vehiculo = new Vehiculo();
                        vehiculo.Id = Convert.ToInt32(reader["Id"]);
                        vehiculo.Marca = reader["marca"].ToString();
                        vehiculo.Modelo = reader["modelo"].ToString();
                        vehiculo.year = reader["año"].ToString();
                        vehiculo.Kilometros = Convert.ToDouble(reader["kilometros"]);
                        vehiculo.Precio = Convert.ToDouble(reader["precio"]);

                        lista.Add(vehiculo);
                    }

                return View(lista);
            }
        }
    }
}