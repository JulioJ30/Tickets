using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_MODEL.Sistema;

namespace WEB.Controllers
{
    public class LoginController : Controller
    {
        #region INSTANCIAS

        ModulosModelo objModulosM = new ModulosModelo();

        #endregion

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getmodulos()
        {
            return Json(objModulosM.getModulos(), JsonRequestBehavior.AllowGet);
        }
    }
}