using IDGS904ASP.Models;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class CinepolisController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calcular(Cine cine)
        {
            double precioBoleta = 12;
            double subtotal;
            double descuento = 0;

            if (cine.CantidadBoletas > (cine.CantidadCompradores * 7))
            {
                ViewBag.Error = "Se excedió el límite de boletos por persona";
                return View("Index");
            }

            subtotal = cine.CantidadBoletas * precioBoleta;

            if (cine.CantidadBoletas > 5)
            {
                descuento = subtotal * 0.15;
            }
            else if (cine.CantidadBoletas >= 3)
            {
                descuento = subtotal * 0.10;
            }

            subtotal = subtotal - descuento;

           
            if (cine.TarjetaCineco)
            {
                subtotal = subtotal - (subtotal * 0.10);
            }

            cine.TotalPagar = subtotal;

            return View("Calcular", cine);
        }
    }
}