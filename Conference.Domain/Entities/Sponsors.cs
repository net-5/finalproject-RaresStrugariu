using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conference.Domain.Entities
{
    public partial class Sponsors
    {
        public Sponsors()
        {
            SponsorPhoto = new HashSet<SponsorPhoto>();
        }

        public int Id { get; set; }
         [Required]
      public string Name { get; set; }
         [Required]
      public string Website { get; set; }
        public string Facebook { get; set; }
         [Required]
         [MaxLength(255)]
      public string Description { get; set; }
        public string PageSlug { get; set; }
        public int SponsorTypeId { get; set; }
        public bool Active { get; set; }
         [Required]
      public string Edition { get; set; }

        public virtual SponsorTypes SponsorType { get; set; }
        public virtual ICollection<SponsorPhoto> SponsorPhoto { get; set; }


    }
}
