using PRUEBAS_LOGIN.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRUEBAS_LOGIN.Controllers
{
    public class CalificacionesController : Controller
    {
        static string cadena = "Data Source=OROZCO;Initial Catalog=DB_ACCESO;Integrated Security=true";
        [HttpGet]
        public ActionResult ObtenerCalificaciones()
        {
            List<calificacion1> calificaciones = new List<calificacion1>();

            using (SqlConnection cn = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("ObtenerCalificaciones", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        calificacion1 calificacion = new calificacion1
                        {
                            NombreEstudiante = reader["NombreEstudiante"].ToString(),
                            Calificacion = Convert.ToInt32(reader["Calificacion"]),
                            Asignatura = reader["Asignatura"].ToString()
                        };

                        calificaciones.Add(calificacion);
                    }
                }
            }

            return View(calificaciones);
        }

        [HttpPost]
        public ActionResult ObtenerCalificaciones(calificacion1 calificacion)
        {
            // No necesitas hacer nada aquí relacionado con el Stored Procedure en este caso
            // Puedes realizar aquí otras operaciones si es necesario

            return View(calificacion);
        }
    }
}

