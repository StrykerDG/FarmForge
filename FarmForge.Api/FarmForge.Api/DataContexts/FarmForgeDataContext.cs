using FarmForge.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmForge.Api.DataContexts
{
    public class FarmForgeDataContext : DbContext
    {
        public FarmForgeDataContext() { }

        public FarmForgeDataContext(DbContextOptions<FarmForgeDataContext> options) : base(options) { }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Interface> Interfaces { get; set; }
        public DbSet<InterfaceType> InterfaceTypes { get; set; }
        public DbSet<Telemetry> Telemetry { get; set; }
    }
}
