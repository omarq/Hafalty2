using System;
using System.Collections.Generic;

namespace Haflaty.Domain.Entities
{
    public class Venue
    {

        public Venue()
        {
            Services = new HashSet<Service>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public string Description { get; set; }

        public ICollection<Service> Services { get; private set; }


    }
}
