using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Datos.Model;
using Datos;

namespace Hoteles.Controllers
{
    public class SedesController : Controller
    {
        // GET: Sede
        public ActionResult Index()
        {
            return View();

        }

        public JsonResult List()
        {
            List<SEDES> ListaSedes = new List<SEDES>();
            using (HOTELESEntities db = new HOTELESEntities()) 
            {                
                var Listaux = (from s in db.Sede
                               select s).ToList();
                if (Listaux != null)
                {
                    foreach (var item in Listaux)
                    {
                        SEDES itemsede = new SEDES();
                        itemsede.ID_SEDE = item.ID_SEDE; 
                        itemsede.NOMBRE_SEDE = item.NOMBRE_SEDE;
                        itemsede.CUPO_MAX = item.CUPO_MAX;
                        ListaSedes.Add(itemsede);
                    }
                }
            }
            return Json(ListaSedes, JsonRequestBehavior.AllowGet);
        }

        // GET: Sede/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sede/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sede/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sede/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sede/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sede/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sede/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
