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
    public class SponsorTypesController : Controller
   {
      // GET: Sponsors
      private readonly ISponsorTypesService sponsorTypesService;
      public SponsorTypesController(ISponsorTypesService sponsorTypesService)
      {
         this.sponsorTypesService = sponsorTypesService;
      }

      [Area("Admin")]
      // GET: Sponsors
      public ActionResult Index()
      {
         IEnumerable<SponsorTypes> allSponsorTypes = sponsorTypesService.GetAllSponsorTypes();
         return View(allSponsorTypes);
      }

      [Area("Admin")]
      // GET: Sponsors/Details/5
      public ActionResult Details(int id)
      {
         SponsorTypes sponsorTypes = sponsorTypesService.GetSponsorTypeById(id);

         SponsorTypesViewModel model = new SponsorTypesViewModel();
         sponsorTypes.InjectFrom(sponsorTypes);
         return View(sponsorTypes);
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
      public ActionResult Create(SponsorTypes model)
      {

         if (ModelState.IsValid)
         {
            SponsorTypes sponsorTypes = new SponsorTypes();
            sponsorTypes.InjectFrom(model);
            var createNewSponsorType = sponsorTypesService.AddSponsorType(sponsorTypes);
            if (createNewSponsorType == null)
            {
               ModelState.AddModelError("Name", "SponsorTypes name must be unique!");
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
         var sponsorTypes = sponsorTypesService.GetSponsorTypeById(id);
         SponsorTypesViewModel model = new SponsorTypesViewModel();
         model.InjectFrom(sponsorTypes);
         return View(model);


      }

      [Area("Admin")]
      // POST: Sponsors/Edit/5
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit(int id, SponsorTypesViewModel model)
      {

         if (ModelState.IsValid)
         {
            SponsorTypes sponsorTypes = new SponsorTypes();
            sponsorTypes.InjectFrom(model);
            var sponsorTypeToUpdate = sponsorTypesService.UpdateSponsorType(sponsorTypes);
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
         var sponsorTypeToDelete = sponsorTypesService.GetSponsorTypeById(id);
         SponsorTypesViewModel model = new SponsorTypesViewModel();
         model.InjectFrom(sponsorTypeToDelete);
         return View(model);
      }

      [Area("Admin")]
      // POST: Sponsors/Delete/5
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Delete(int id, SponsorsViewModel model)
      {
         SponsorTypes sponsorTypeToDelete = new SponsorTypes();
         sponsorTypeToDelete = sponsorTypesService.GetSponsorTypeById(id);
         model.InjectFrom(sponsorTypeToDelete);
         sponsorTypesService.Delete(sponsorTypeToDelete);
         sponsorTypesService.Save();
         return RedirectToAction(nameof(Index));




      }
   }
}