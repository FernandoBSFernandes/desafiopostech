using Microsoft.EntityFrameworkCore;

namespace MainWebAPI.DbContextConfig
{
    public class DesafioContext : DbContext
    {

        public DbSet<Power> Powers { get; set; }

        public DesafioContext(DbContextOptions<DesafioContext> options) : base(options)
        {            
        }

        public DesafioContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseNpgsql("host=db.onpggwsicxwenzhctuij.supabase.co;user=postgres;password=8ylj6Ie5iGTVyvCq");
    }

}
