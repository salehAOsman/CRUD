using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int id, string name, string city, string phone)
        {
            Person newPer = new Person();
            newPer.Id = id;
            newPer.Name = name;
            newPer.City = city;
            newPer.Phone = phone;

            //we add to this static list ad a database
            DataList.dataList.Add(newPer);

            //redirect to go back index side
            RedirectToAction("Index");
        }
    } 
}