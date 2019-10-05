using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{
    public class SponsorsController : Controller
    {
      // GET: Sponsors
      private readonly ISponsorsService sponsorsService;
      public SponsorsController(ISponsorsService sponsorsService)
      {
         this.sponsorsService = sponsorsService;
      }

      [Area("Admin")]
      // GET: Sponsors
      public ActionResult Index()
      {
         IEnumerable<Sponsors> allSponsors = sponsorsService.GetAllSponsors();
         return View(allSponsors);
      }

      [Area("Admin")]
      // GET: Sponsors/Details/5
      public ActionResult Details(int id)
      {
         Sponsors sponsors = sponsorsService.GetSponsorById(id);
         
         SponsorsViewModel model = new SponsorsViewModel();
         sponsors.InjectFrom(sponsors);
         return View(sponsors);
      }

      [Area("Admin")]
      // GET: Sponsors/Create
      public ActionResult Create()
      {
         return View();
      }

      [Area("Admin")]
      // POST: Sponsors/Create
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create(Sponsors model)
      {
         
         if (ModelState.IsValid)
         {
            Sponsors sponsors = new Sponsors();
            sponsors.InjectFrom(model);
            var createNewSponsor = sponsorsService.AddSponsor(sponsors);
            if (createNewSponsor == null)
            {
               ModelState.AddModelError("Name", "Sponsors name must be unique!");
               return View(model);
            }
            return RedirectToAction(nameof(Index));
         }
         else
         {
            return View(model);
         }
         
         
           
         
      }

      [Area("Admin")]
      // GET: Sponsors/Edit/5
      public ActionResult Edit(int id)
      {
         var sponsor = sponsorsService.GetSponsorById(id);
         SponsorsViewModel model = new SponsorsViewModel();
         model.InjectFrom(sponsor);
         return View(model);
         
         
      }

      [Area("Admin")]
      // POST: Sponsors/Edit/5
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit(int id, SponsorsViewModel model)
      {

         if (ModelState.IsValid)
         {
            Sponsors sponsors = new Sponsors();
            sponsors.InjectFrom(model);
            var sponsorToUpdate = sponsorsService.UpdateSponsor(sponsors);
            return RedirectToAction(nameof(Index));
         }
         else
         {
            return View(model);
         }
      }

      [Area("Admin")]
      // GET: Sponsors/Delete/5
      public ActionResult Delete(int id)
      {
         var sponsorToDelete = sponsorsService.GetSponsorById(id);
         SponsorsViewModel model = new SponsorsViewModel();
         model.InjectFrom(sponsorToDelete);
         return View(model);
      }

      [Area("Admin")]
      // POST: Sponsors/Delete/5
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Delete(int id,SponsorsViewModel model)
      {
         Sponsors sponsorToDelete = new Sponsors();
         sponsorToDelete = sponsorsService.GetSponsorById(id);
         model.InjectFrom(sponsorToDelete);
         sponsorsService.Delete(sponsorToDelete);
         sponsorsService.Save();
         return RedirectToAction(nameof(Index));



        
      }
   }
}