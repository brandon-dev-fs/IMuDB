using IMuDB.Domain.Entities.Acts;
using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Entities.Genres;
using IMuDB.Domain.Entities.Instruments;
using IMuDB.Domain.Entities.Musicians;
using IMuDB.Domain.Entities.Songs;
using IMuDB.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace IMuDB.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ActEntity> Acts { get; set; }
        public DbSet<AlbumEntity> Albums { get; set; }
        public DbSet<MusicianEntity> Musicians { get; set; }
        public DbSet<GenreEntity> Genres { get; set; }
        public DbSet<InstrumentEntity> Instruments { get; set; }
        public DbSet<SongEntity> Songs { get; set; }
        public DbSet<UserEntity> Users { get; set; }

    }
}
