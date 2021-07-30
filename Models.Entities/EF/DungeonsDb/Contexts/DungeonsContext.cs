using Microsoft.EntityFrameworkCore;
using Models.Entities.EF;
using Models.Entities.EF.DungeonsDb.Configurations;

namespace Models.Entities.EntityFW.Contexts
{
    public class DungeonsContext : DbContext
    {
        public DungeonsContext(DbContextOptions<DungeonsContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CharactersConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(JobConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RelationShipConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RelationShipTypeConfig).Assembly);
        }

        public virtual DbSet<Characters> Characters { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<RelationShipType> RelationShipType { get; set; }
        public virtual DbSet<RelationShip> RelationShip { get; set; }

   
    }
}
