using System;

namespace FishingTanks.Domain.Models
{
    public class Licens : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public UserProfile UserProfile { get; set; }
        
    }
}