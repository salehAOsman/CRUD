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
            return View(DataList.dataList);
        }
        //this type of this method is post because we need to sent info serach to server from the same index page 
        [HttpPost]
        public ActionResult Index(string searchText)
        {
            return View(DataList.dataList.Where(x => x.Name.ToLower().Contains(searchText.ToLower())) /*|| x = > x.City.ToLower().Contains(searchText.ToLower()))*/ );
            /*return View( DataList.dataList.Where(x => x.Name == searchText));*///it work with exact search 
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
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //var id = Request.QueryString["id"];

            //retrive data from database
            //search for one object inside list that has matching id but it will bring all preoprties here then we put it inside object "person"
            Person person = DataList.dataList.SingleOrDefault(x => x.Id == id);

            return View(person);
        }

        [HttpPost]// this person after update by user then we will push it to server
        public ActionResult Edit(Person personNew)
        {
            //here we need to get the id for old person that has same id for new one efter update
            //we have this 
            Person perOld = DataList.dataList.SingleOrDefault(x => x.Id == personNew.Id);
            // here we catch old one then we update with new info by this code
            perOld.Name = personNew.Name; // perOld refere to the person in list we do not need to add to list because we do it already
            perOld.Phone = personNew.Phone;
            perOld.City = personNew.City;

            return RedirectToAction("Index");
        }

        // we need just get method with out post
        [HttpGet]
        public ActionResult Details(int id)
        {
            Person person = DataList.dataList.SingleOrDefault(x => x.Id == id);

            return View(person);
        }
        
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Person person = DataList.dataList.SingleOrDefault(x => x.Id == id);

            return View(person);
        }
        [HttpPost]
        public ActionResult ConfirmDelete(int id)
        {
            //ToDo
            //now we fitch the object then
            Person person = DataList.dataList.SingleOrDefault(x => x.Id == id);
            // here we will delete this opject by remove method but with data base we need another code that is method called "SaveChanges"
            DataList.dataList.Remove(person);

            return RedirectToAction("Index");
        }

    }
}