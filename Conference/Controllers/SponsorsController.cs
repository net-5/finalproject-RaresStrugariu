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
    public class SponsorsController : Controller
    {
      // GET: Sponsors
      private readonly ISponsorsService sponsorsService;
      public SponsorsController(ISponsorsService sponsorsService)
      {
         this.sponsorsService = sponsorsService;
      }

     
      // GET: Sponsors
      public ActionResult Index()
      {
         IEnumerable<Sponsors> allSponsors = sponsorsService.GetAllSponsors();
         return View(allSponsors);
      }

      
      // GET: Sponsors/Details/5
      public ActionResult Details(int id)
      {
         Sponsors sponsors = sponsorsService.GetSponsorById(id);

         SponsorsViewModel1 model = new SponsorsViewModel1();
         sponsors.InjectFrom(sponsors);
         return View(sponsors);
      }

      // GET: Sponsors/Create
      public ActionResult Create()
        {
            return View();
        }

        // POST: Sponsors/Create
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

        // GET: Sponsors/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sponsors/Edit/5
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

        // GET: Sponsors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sponsors/Delete/5
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