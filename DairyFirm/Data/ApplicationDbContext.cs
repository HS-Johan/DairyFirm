using DairyFirm.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DairyFirm.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CowInfo> CowInfos { get; set; } = default!;
        public DbSet<FeedingInfo> FeedingInfos { get; set; } = default!;
        public DbSet<MeatProducion> MeatProducions { get; set; } = default!;
        public DbSet<MilkProduction> MilkProductions { get; set; } = default!;
        public DbSet<VaccineInfo> VaccineInfos { get; set; } = default!;
        public DbSet<VaccineApply> VaccineApplies { get; set; } = default!;
    }
}
