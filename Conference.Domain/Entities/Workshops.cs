using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conference.Domain.Entities
{
    public partial class Workshops
    {
        [Required]
        [MaxLength (4)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Prerequisites { get; set; }
        public string Requirements { get; set; }
        public int? PlacesAvailable { get; set; }
        public string Edition { get; set; }
        public int SpeakerId { get; set; }
        public string RegistrationLink { get; set; }

        public virtual Speakers Speaker { get; set; }
    }
}
