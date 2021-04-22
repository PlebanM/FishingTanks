using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FishingTanks.Domain.Models
{
    public class UserProfile : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        [StringLength(11)]
        public string PESEL { get; set; }

        public IEnumerable<Licens> Licenses { get; set; }
        
    }
}