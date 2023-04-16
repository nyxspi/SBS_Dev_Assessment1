using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBS_2page_webApp.Controllers
{
    public class Info_Controller : Controller
    {
        // GET: Info_
        public ActionResult Index()
        {
            return View();
        }

        // GET: Info_/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Info_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Info_/Create
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

        // GET: Info_/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Info_/Edit/5
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

        // GET: Info_/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Info_/Delete/5
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
