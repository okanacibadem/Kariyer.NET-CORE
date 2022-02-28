using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kariyer.Models;

namespace Kariyer.Data
{
    public class KariyerDbContext:DbContext
    {
        public KariyerDbContext(DbContextOptions<KariyerDbContext> options) : base(options)
        {

        }
        public virtual DbSet<BasvuruSahibi> BasvuruSahibis { get; set; }
        public virtual DbSet<Deneyim> Deneyims { get; set; }

    }
}
