using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Models
{
   public class SponsorTypesViewModel1
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public int Order { get; set; }
      [Required]
      [MaxLength(20)]
      public string Edition { get; set; }

      public virtual ICollection<Sponsors> Sponsors { get; set; }
   }
}
