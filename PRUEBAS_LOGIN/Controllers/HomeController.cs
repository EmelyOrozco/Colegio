using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PRUEBAS_LOGIN.Permisos;

namespace PRUEBAS_LOGIN.Controllers
{

    [ValidarSesion]
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult CerrarSesion()
        {
            Session["usuario"] = null;
            return RedirectToAction("Login", "Acceso");
        }

        public ActionResult Grado1()
        {
            ViewBag.Message = "Information for Grado 1";
            // Puedes colocar lógica específica para Grado1 aquí
            return View();
        }

        public ActionResult Grado2()
        {
            ViewBag.Message = "Information for Grado 2";
            // Puedes colocar lógica específica para Grado2 aquí
            return View();
        }

        public ActionResult Grado3()
        {
            ViewBag.Message = "Information for Grado 3";
            // Puedes colocar lógica específica para Grado3 aquí
            return View();
        }

        public ActionResult Grado4()
        {
            ViewBag.Message = "Information for Grado 4";
            // Puedes colocar lógica específica para Grado1 aquí
            return View();
        }

        public ActionResult Grado5()
        {
            ViewBag.Message = "Information for Grado 5";
            // Puedes colocar lógica específica para Grado2 aquí
            return View();
        }

        public ActionResult Grado6()
        {
            ViewBag.Message = "Information for Grado 6";
            // Puedes colocar lógica específica para Grado3 aquí
            return View();
        }

        public ActionResult Grado7()
        {
            ViewBag.Message = "Information for Grado 7";
            // Puedes colocar lógica específica para Grado1 aquí
            return View();
        }

        public ActionResult Grado8()
        {
            ViewBag.Message = "Information for Grado 8";
            // Puedes colocar lógica específica para Grado2 aquí
            return View();
        }

        public ActionResult Asistencia1()
        {
            ViewBag.Message = "Information for Asistencia";
            // Puedes colocar logica para Asistencia
            return View();
        }


        public ActionResult Comentarios1()
        {
            ViewBag.Message = "Information for Comentarios";
            // Puedes colocar lógica específica para Grado2 aquí
            return View();
        }

        public ActionResult Calificaciones1()
        {
            ViewBag.Message = "Information for Calificaciones";
            return View();

        }

        // Otras acciones y métodos del controlador


    }
}