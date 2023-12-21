
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Reestrs.Database.Models;

namespace Reestrs.Database
{
    public class ReestrsDbContext: DbContext
    {
        public DbSet<PersList> PersLists { get; set; }
        public DbSet<Pers> Pers { get; set; }
        public DbSet<ZGLV_L> Zglvs_l { get; set; }
        public DbSet<ZGLV_H> Zglvs_h { get; set; }
        public DbSet<ZL_LIST> ZL_LISTs { get; set; }
        public DbSet<SCHET> SCHETs { get; set; }
        public DbSet<ZAP> ZAPs { get; set; }
        public DbSet<PACIENT> PACIENTs { get; set; }
        public DbSet<Z_SL> Z_SLs { get; set; }
        public DbSet<SANK> SANKs { get; set; }
        public DbSet<SL> SLs { get; set; }
        public DbSet<CONS> CONSs { get; set; }
        public DbSet<DS2_N> DS2_Ns { get; set; }
        public DbSet<KSG_KPG> KSG_KPGs { get; set; }
        public DbSet<SL_KOEF> SL_KOEFs { get; set; }
        public DbSet<LEK_PR> LEK_PRs { get; set; }
        public DbSet<LEK_DOSE> LEK_DOSEs { get; set; }
        public DbSet<NAPR> NAPRs { get; set; }
        public DbSet<NAZ> NAZs { get; set; }
        public DbSet<ONK_SL> ONK_SLs { get; set; }
        public DbSet<B_DIAG> B_DIAGs { get; set; }
        public DbSet<B_PROT> B_PROTs { get; set; }
        public DbSet<ONK_USL> ONK_USLs { get; set; }
        public DbSet<USL> USLs { get; set; }
        public DbSet<MED_DEV> MED_DEVs { get; set; }
        public DbSet<MR_USL_N> MR_USL_Ns { get; set; }        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=reestrs;Integrated Security=True;MultipleActiveResultSets=True;")
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }
    }
}
