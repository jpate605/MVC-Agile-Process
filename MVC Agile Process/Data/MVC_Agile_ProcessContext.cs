using Microsoft.EntityFrameworkCore;

namespace MVC_Agile_Process.Data
{
    public class MVC_Agile_ProcessContext : DbContext
    {
        public MVC_Agile_ProcessContext(DbContextOptions<MVC_Agile_ProcessContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Agile_Process.Models.Project> Project { get; set; } = default!;
    }
}
