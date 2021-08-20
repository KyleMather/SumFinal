using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SumFinal.Models;

namespace SumFinal.Controllers
{
    public class PapersController : Controller
    {
        // GET: Papers
        public ActionResult Papers()
        {
            using (DBModels DB = new DBModels())
            {
                return View(DB.Pappers.ToList());
            }
           
        }

        // GET: Papers/Details/5
        public ActionResult Details(int id)
        {
            using (DBModels DB = new DBModels())
            {
                return View(DB.Pappers.Where(x => x.PaperID == id).FirstOrDefault()); ;
            }

        }

        // GET: Papers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Papers/Create
        [HttpPost]
        public ActionResult Create(Papper pap)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBModels DB = new DBModels())
                {
                    DB.Pappers.Add(pap);
                    DB.SaveChanges();
                }
                return RedirectToAction("Papers");
            }
            catch
            {
                return View();
            }
        }

        // GET: Papers/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels DB = new DBModels())
            {
                return View(DB.Pappers.Where(x => x.PaperID == id).FirstOrDefault()); ;
            }
        }

        // POST: Papers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id , Papper pap)
        {
            try
            {
                // TODO: Add update logic here
                using (DBModels DB = new DBModels())
                {
                    DB.Entry(pap).State = EntityState.Modified;
                    DB.SaveChanges();
                }
                return RedirectToAction("Papers");
            }
            catch
            {
                return View();
            }
        }

        // GET: Papers/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels DB = new DBModels())
            {
                return View(DB.Pappers.Where(x => x.PaperID == id).FirstOrDefault()); ;
            }
        }

        // POST: Papers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Papper pap)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModels DB = new DBModels())
                {
                     pap= DB.Pappers.Where(x => x.PaperID == id).FirstOrDefault();
                    DB.Pappers.Remove(pap);
                    DB.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
