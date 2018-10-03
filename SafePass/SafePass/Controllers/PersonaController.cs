using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SafePass.Models;
namespace SafePass.Controllers
{
    public class PersonaController : Controller
    {
        DB_safePassEntities db = new DB_safePassEntities();
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetPersonaValidation(string id = null) {

            if (id != null && id != "")
            {
                var lista = db.tb_persona.Select(x => new
                {
                    x.id_persona,
                    x.nombres,
                    x.apellidos,
                    x.celular,
                    x.ciudad,
                    x.direccion,
                    x.dni,
                    x.fecha_nacimiento
                }).Where(x => x.dni == id).ToList();

                if (lista.Count() == 0)
                {
                    return Json(lista, JsonRequestBehavior.AllowGet);

                }
                else {
                    return Json(lista, JsonRequestBehavior.AllowGet);

                }
            }
            else
                return Json("error", JsonRequestBehavior.AllowGet);

        }


    }
}