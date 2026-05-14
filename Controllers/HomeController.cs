using IDGS904ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    // Controlador principal de la aplicación
    public class HomeController : Controller
    {

        // =========================================================
        // MÉTODOS BÁSICOS
        // =========================================================
        // Acción principal que devuelve una Vista (View)
        // Se ejecuta cuando entras a /Home/Index
        //public ActionResult Index()
        //{
            //return View();
        //}

        // Acción About
        // Muestra un mensaje usando ViewBag
        //public ActionResult About()
        //{
            //ViewBag.Message = "Your application description page.";
            //return View();
        //}

        // Acción Contact
        // Muestra un mensaje en la vista Contact
        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //// =========================================================
        //// EJEMPLOS DE DIFERENTES TIPOS DE RESULTADOS EN ASP.NET MVC
        //// =========================================================

        //// ---------------------------------------------------------
        //// 1. ContentResult
        //// Devuelve texto plano en el navegador
        //// ---------------------------------------------------------
        //public ContentResult TextoPlano()
        //{
        //    return Content("Paulo Essau ASP.NET");
        //}


        //// ---------------------------------------------------------
        //// 2. ActionResult con Content
        //// ActionResult es genérico y puede devolver varios tipos
        //// ---------------------------------------------------------
        //public ActionResult TextoGenerico()
        //{
        //    return Content("Paulo Essau ASP.NET");
        //}


        //// ---------------------------------------------------------
        //// 3. ViewResult
        //// Devuelve una vista específica
        //// ---------------------------------------------------------
        //public ViewResult VistaEjemplo()
        //{
        //    return View();
        //}

        //// ---------------------------------------------------------
        //// 4. JsonResult
        //// Devuelve datos en formato JSON
        //// Muy usado para APIs o AJAX
        //// ---------------------------------------------------------
        //public JsonResult ObtenerAlumnos()
        //{
        //    // Creación de objetos Persona
        //    var alumno1 = new Persona()
        //    {
        //        Nombre = "Paulo",
        //        Edad = 22,
        //        Empleado = true
        //    };

        //    var alumno2 = new Persona()
        //    {
        //        Nombre = "Karlauwu",
        //        Edad = 21,
        //        Empleado = false
        //    };
        //    // Lista de personas
        //    List<Persona> alumnos = new List<Persona>()
        //    {
        //        alumno1,
        //        alumno2
        //    };
        //    // Retorna JSON
        //    return Json(alumnos, JsonRequestBehavior.AllowGet);
        //}


        // ---------------------------------------------------------
        // 5. ActionResult devolviendo JSON
        // Similar al anterior pero usando ActionResult
        // ---------------------------------------------------------
        //public ActionResult ObtenerAlumnos2()
        //{
            //var alumno1 = new Persona()
        //    {
        //        Nombre = "Paulo",
        //        Edad = 22,
        //        Empleado = true
        //    };

        //    var alumno2 = new Persona()
        //    {
        //        Nombre = "Karlauwu",
        //        Edad = 21,
        //        Empleado = false
        //    };

        //    return Json(
        //        new List<Persona>() { alumno1, alumno2 },
        //        JsonRequestBehavior.AllowGet
        //    );
        //}

        // ---------------------------------------------------------
        // 6. RedirectResult
        // Redirecciona a otra URL
        // ---------------------------------------------------------
        //public RedirectResult IrAGoogle()
        //{
            //return Redirect("https://google.com.mx");
        //}

        public RedirectToRouteResult Index()
        {
            return RedirectToAction("Index", "Pruebas");
        }
    }
}