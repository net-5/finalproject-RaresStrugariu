using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{

   public interface ISponsorsRepository
   {
      List<Sponsors> GetAllSponsors();
      Sponsors GetSponsorById(int id);
      Sponsors Update(Sponsors sponsorToUpdate);
      Sponsors AddSponsor(Sponsors sponsorToBeAdded);
      bool IsUniqueSponsor(string sponsorName);
      void Delete(Sponsors sponsorToDelete);
      void Save();
   }
   public class SponsorsRepository : ISponsorsRepository
   {
      private readonly ConferenceContext conferenceContext;

      public SponsorsRepository(ConferenceContext conferenceContext)
      {
         this.conferenceContext = conferenceContext;
      }

      public List<Sponsors> GetAllSponsors()
      {
         return conferenceContext.Sponsors.ToList();
      }

      public Sponsors AddSponsor(Sponsors sponsorToBeAdded)
      {
         var addedSponsor = conferenceContext.Add(sponsorToBeAdded);
         conferenceContext.SaveChanges();
         return addedSponsor.Entity;
      }

      public Sponsors GetSponsorById(int id)
      {
         return conferenceContext.Sponsors.Find(id);
      }

      public Sponsors Update(Sponsors sponsorToUpdate)
      {
         var updatedSponsor = conferenceContext.Update(sponsorToUpdate);
         conferenceContext.SaveChanges();
         return updatedSponsor.Entity;
      }

      public bool IsUniqueSponsor(string sponsorName)
      {
         int nr = conferenceContext.Sponsors.Count(x => x.Name == sponsorName);
         if (nr == 0)
         {
            return true;
         }
         else
         {
            return false;
         }

      }


      public void Delete(Sponsors sponsorToDelete)
      {
         sponsorToDelete = conferenceContext.Sponsors.Find(sponsorToDelete.Id);
         conferenceContext.Sponsors.Remove(sponsorToDelete);

      }
      public void Save()
      {
         conferenceContext.SaveChanges();
      }
   }
}
