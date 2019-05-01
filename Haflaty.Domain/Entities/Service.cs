using System;
using System.Collections.Generic;
using System.Text;

namespace Haflaty.Domain.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ServiceType Type { get; set; }
        public Guid VenueId { get; set; }  
    }
}
