using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace air_api_test.Models
{
    public class airContext : DbContext
    {
        public airContext(DbContextOptions<airContext> options) : base(options)
        {

        }
        public DbSet<Requesters> Requesters { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<TicketMaster> TicketMaster { get; set; }
        public DbSet<Assets> Assets { get; set; }
        public DbSet<AssetType> AssetType { get; set; }
    }
}
