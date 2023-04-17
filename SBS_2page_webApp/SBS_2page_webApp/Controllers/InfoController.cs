using SBS_2page_webApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBS_2page_webApp.Controllers
{
    public class InfoController : Controller
    {

        public ActionResult Index()
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginController");
            }

            using (var db = new DbContextES())
            {
                var loggedInUser = (Class_Person)Session["LoggedInUser"];
                var userInfo = db.Info.FirstOrDefault(i => i.PersonId == loggedInUser.Id);

                if (userInfo == null)
                {
                    userInfo = new Info_Class
                    {
                        PersonId = loggedInUser.Id
                    };
                }

                return View(userInfo);
            }
        }

        [HttpPost]
        public ActionResult Update(Info_Class model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DbContextES())
                {
                    // Get the current user's ID from the session variable
                    int personId = (int)Session["UserId"];

                    // Update the user's information in the database
                    var info = db.Info.FirstOrDefault(i => i.PersonId == personId);
                    info.TelNo = model.TelNo;
                    info.CellNo = model.CellNo;
                    info.AddressLine1 = model.AddressLine1;
                    info.AddressLine2 = model.AddressLine2;
                    info.AddressLine3 = model.AddressLine3;
                    info.AddressCode = model.AddressCode;
                    info.PostalAddress1 = model.PostalAddress1;
                    info.PostalAddress2 = model.PostalAddress2;
                    info.PostalCode = model.PostalCode;

                    db.SaveChanges();
                }

                // Redirect the user back to the Info page
                return RedirectToAction("Index");
            }

            // If the model state is not valid, return the view with the model
            return View("Info", model);
        }




        /*// GET: Info_
        public ActionResult Index()
        {
            return View();
        }*/

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
