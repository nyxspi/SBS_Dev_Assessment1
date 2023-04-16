using SBS_2page_webApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBS_2page_webApp.Controllers
{
    public class Login_Controller : Controller
    {
        // login class that will display error if input is invalid
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var person = DbContextES.Persons.FirstOrDefault(p => p.Username == username && p.Password == password);
            if (person != null)
            {
                Session["PersonId"] = person.Id;
                return RedirectToAction("Index", "Info");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View("Login");
            }
        }





        // GET: Login_
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login_/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login_/Create
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

        // GET: Login_/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login_/Edit/5
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

        // GET: Login_/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login_/Delete/5
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
