using AdapterSDP;
using BridgeSDP;
using CompositeSDP;
using DecoratorSDP;
using FacadeSDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StructuralDesignPatterns.Controllers
{
    public class StructuralDesignPatternsController : Controller
    {
        public ActionResult DesignPattern()
        {
            return View();
        }
        public ActionResult AdapterSDP()
        {
            List<string> ObjListModuleLeads = new List<string>();
            Employee ObjEmp = new Employee();
            ObjListModuleLeads.Add(ObjEmp.LeadFor(new UMS_Module()));
            ObjListModuleLeads.Add(ObjEmp.LeadFor(new AdapterSDP.DMS_Module()));
            ObjListModuleLeads.Add(ObjEmp.LeadFor(new TMS_Module()));
            ObjListModuleLeads.Add(ObjEmp.LeadFor(new QMS_Module()));
            ObjListModuleLeads.Add(ObjEmp.LeadFor(new REG_Module()));

            return View();
        }
        public ActionResult BridgeSDP()
        {
            List<string> objReach = new List<string>();
            Bridge objBridge = new Bridge();
            EastGodavari objEGD = new EastGodavari();
            WestGodavari objWGD = new WestGodavari();
            objReach.Add(objBridge.ReachTo(objEGD));
            objReach.Add(objBridge.ReachTo(objWGD));
            return View();
        }
        public ActionResult CompositeSDP()
        {
            IEmployee objModule = new CompositeSDP.DMS_Module();
            IEmployee objPL1 = new ProjectLead_1();
            IEmployee objDirector = new Director();
            List<IEmployee> objListEmp = new List<IEmployee>();
            objListEmp.Add(objModule);
            objListEmp.Add(objPL1);
            objListEmp.Add(objDirector);
            List<string> objDesignationList = new List<string>();
            foreach (var Objitem in objListEmp)
            {
                objDesignationList.Add(Objitem.Designation());
            }
            return View();
        }
        public ActionResult DecoratorSDP()
        {
            List<string> objCarList = new List<string>();

            //Car objAcCar = new WithAC();
            objCarList.Add(new WithAC().CarType());
            //Car objCarAll = new WithSoundSystemAndAC();
            objCarList.Add(new WithSoundSystemAndAC().CarType());
            return View();
        }
        public ActionResult FacadeSDP()
        {
            List<string> objRestaurantItems = new List<string>();

            var facadeForClient = new RestaurantFacade();
            objRestaurantItems.Add(facadeForClient.GetNonVegPizza());
            objRestaurantItems.Add(facadeForClient.GetVegPizza());
            objRestaurantItems.Add(facadeForClient.GetGarlicBread());
            objRestaurantItems.Add(facadeForClient.GetCheesyGarlicBread());
            return View();
        }
        public ActionResult FlyweightSDP()
        {
            return View();
        }
        public ActionResult ProxySDP()
        {
            return View();
        }


        //fgfdg
        // GET: StructuralDesignPatterns
        public ActionResult Index()
        {
            return View();
        }

        // GET: StructuralDesignPatterns/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StructuralDesignPatterns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StructuralDesignPatterns/Create
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

        // GET: StructuralDesignPatterns/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StructuralDesignPatterns/Edit/5
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

        // GET: StructuralDesignPatterns/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StructuralDesignPatterns/Delete/5
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
