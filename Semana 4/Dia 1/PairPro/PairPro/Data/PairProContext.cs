using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PairPro.Models;

namespace PairPro.Data
{
    public class PairProContext : DbContext
    {
        public PairProContext (DbContextOptions<PairProContext> options)
            : base(options)
        {
        }

        public DbSet<Vehiculo>? Vehiculo { get; set; }
    }
}
