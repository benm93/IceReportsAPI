using IceReportsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class ReportsContext : DbContext
    {
        public ReportsContext(DbContextOptions<ReportsContext> options)
            : base(options)
        { }

        public DbSet<Report> Reports { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Climb> Climbs { get; set; }
        public DbSet<Area> Areas { get; set; }
    }
}