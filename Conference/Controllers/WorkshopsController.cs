using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Models;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Controllers
{
    public class WorkshopsController : Controller
    {
      private readonly IWorkshopService workshopService;
      public WorkshopsController(IWorkshopService workshopService)
      {
         this.workshopService = workshopService;
      }

      
      // GET: Workshops
      public ActionResult Index()
      {
         IEnumerable<Workshops> allWorkshops = workshopService.GetAllWorkshops();
         return View(allWorkshops);
      }

      
      // GET: Workshops/Details/5
      public ActionResult Details(int id)
      {
         Workshops workshops = workshopService.GetWorkshopById(id);
         WorkshopsViewModel1 model = new WorkshopsViewModel1();
         model.InjectFrom(workshops);
         return View(workshops);
      }

      // GET: Workshop/Create
      public ActionResult Create()
        {
            return View();
        }

        // POST: Workshop/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Workshop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Workshop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Workshop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Workshop/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}