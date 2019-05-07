using System;
using System.Collections.Generic;
using System.Text;
using Haflaty.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Haflaty.Application.Interfaces
{
    public interface IHafaltyDbContext
    {
        DbSet<Venue> Venus { set; get; }   


    }
}
