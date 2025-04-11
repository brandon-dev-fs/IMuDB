using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Entities.Artists;
using IMuDB.Domain.Entities.Songs;
using Microsoft.EntityFrameworkCore;

namespace IMuDB.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ArtistEntity> Artists { get; set; }
        public DbSet<AlbumEntity> Albums { get; set; }
        public DbSet<SongEntity> Songs { get; set; }
    }
}
