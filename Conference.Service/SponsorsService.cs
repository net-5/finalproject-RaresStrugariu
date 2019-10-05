using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Service
{
   public interface ISponsorsService
   {
      IEnumerable<Sponsors> GetAllSponsors();
      Sponsors GetSponsorById(int id);
      Sponsors AddSponsor(Sponsors SponsorToBeAdded);
      Sponsors UpdateSponsor(Sponsors SponsorToUpdate);
      void Delete(Sponsors SponsorToDelete);
      void Save();
   }
   public class SponsorsService : ISponsorsService
   {
      private readonly ISponsorsRepository SponsorsRepository;
      public SponsorsService(ISponsorsRepository SponsorsRepository)
      {
         this.SponsorsRepository = SponsorsRepository;
      }

      private bool IsUniqueSponsor(string SponsorName)
      {
         if (SponsorsRepository.IsUniqueSponsor(SponsorName) == true)
         {
            return true;
         }
         else
         {
            return false;
         }
      }
      public Sponsors AddSponsor(Sponsors SponsorToBeAdded)
      {
         if (IsUniqueSponsor(SponsorToBeAdded.Name))
         {
            return SponsorsRepository.AddSponsor(SponsorToBeAdded);
         }
         else
         {
            return null;
         }
      }

      public void Delete(Sponsors SponsorToDelete)
      {
         SponsorsRepository.Delete(SponsorToDelete);
      }

      public IEnumerable<Sponsors> GetAllSponsors()
      {
         return SponsorsRepository.GetAllSponsors();
      }

      public Sponsors GetSponsorById(int id)
      {
         return SponsorsRepository.GetSponsorById(id);
      }

      public void Save()
      {
         SponsorsRepository.Save();
      }

      public Sponsors UpdateSponsor(Sponsors SponsorToUpdate)
      {
         return SponsorsRepository.Update(SponsorToUpdate);
      }
   }
}
