namespace NWS_cs
{
    using System.Data.Entity;

    public partial class NwsContext : DbContext
    {
        public NwsContext()
            : base("name=NwsContext")
        {
        }

        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Officer> Officers { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {    
        }
    }
}
