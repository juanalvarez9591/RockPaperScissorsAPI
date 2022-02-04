using Microsoft.EntityFrameworkCore;
using LMADM.Models;

namespace LMADM.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Move> Moves { get; set; }

        public DbSet<GameLog> GameLogs { get; set; }

    }
}
