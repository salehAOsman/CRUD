﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class CrudController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Crud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crud/Create
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

        // GET: Crud/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Crud/Edit/5
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

        // GET: Crud/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Crud/Delete/5
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
