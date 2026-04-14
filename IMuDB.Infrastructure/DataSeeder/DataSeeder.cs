using IMuDB.Domain.Entities.Acts;
using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Entities.Genres;
using IMuDB.Domain.Entities.Instruments;
using IMuDB.Domain.Entities.Musicians;
using IMuDB.Domain.Entities.Songs;
using IMuDB.Domain.Enums;

namespace IMuDB.Infrastructure.DataSeeder
{
    public class DataSeeder
    {
        private readonly DataContext _context;

        private static readonly List<InstrumentEntity> _instruments = new()
        {
            new InstrumentEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Instrument = "Lead Vocals",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            new InstrumentEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Instrument = "Background Vocals",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            new InstrumentEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Instrument = "Lead Guitar",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            new InstrumentEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Instrument = "Rhythm Guitar",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            new InstrumentEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Instrument = "Bass Guitar",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            new InstrumentEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Instrument = "Keyboard",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            new InstrumentEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Instrument = "Drums",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
        };

        private static readonly List<ActEntity> _acts = new() {
             new ActEntity {
                Id = Guid.NewGuid().ToString(),
                Name = "John Mayer",
                ImageUrl = "/src/assets/images/acts/John_Mayer/John_Mayer.jpg",
                Musicians = new List<MusicianEntity>
                {
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "John Mayer",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[0],
                            _instruments[2]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    }
                },
                Type = ActType.Solo,
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
             },
             new ActEntity{
                Id = Guid.NewGuid().ToString(),
                Name= "Mumford and Sons",
                ImageUrl = "/src/assets/images/acts/Mumford_and_Sons/Mumford_and_Sons.jpg",
                Musicians = new List<MusicianEntity>
                {
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Marcus Mumford",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[0],
                            _instruments[3],
                            _instruments[6],
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Ben Lovett",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[1],
                            _instruments[5]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Ted Dwane",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[1],
                            _instruments[4]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                },
                Type = ActType.Band,
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
             },
             new ActEntity
             {
                Id = Guid.NewGuid().ToString(),
                Name= "Led Zeppelin",
                ImageUrl = "/src/assets/images/acts/Led_Zeppelin/Led_Zeppelin.jpg",
                Musicians = new List<MusicianEntity>
                {
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Robert Plant",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[0]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Jimmy Page",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[2]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "John Paul Jones",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[4],
                            _instruments[5]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "John Bonham",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[6]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                },
                Type = ActType.Band,
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
             },
             new ActEntity{
                Id = Guid.NewGuid().ToString(),
                Name= "Noah Kahan",
                ImageUrl = "/src/assets/images/acts/Noah_Kahan/Noah_Kahan.jpg",
                Musicians = new List<MusicianEntity>
                {
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Noah Kahan",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[0],
                            _instruments[3],
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    }
                },
                Type = ActType.Solo,
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
             },
             new ActEntity {
                Id = Guid.NewGuid().ToString(),
                Name= "Rage Against the Machine",
                ImageUrl = "/src/assets/images/acts/RATM/RATM.jpg",
                Musicians = new List<MusicianEntity>
                {
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Zack de la Rocha",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[0]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Tom Morello",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[2]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Tim Commerford",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[4]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Brad Wilk",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[6]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                },
                Type = ActType.Band,
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
             },
             new ActEntity {
                Id = Guid.NewGuid().ToString(),
                Name= "The Beatles",
                ImageUrl = "/src/assets/images/acts/The_Beatles/The_Beatles.jpg",
                Musicians = new List<MusicianEntity>
                {
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "John Lennon",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[0],
                            _instruments[1],
                            _instruments[3]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Paul McCartney",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[0],
                            _instruments[1],
                            _instruments[4]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "George Harrison",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[0],
                            _instruments[1],
                            _instruments[2]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Ringo Starr",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[0],
                            _instruments[1],
                            _instruments[6]
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                },
                Type = ActType.Band,
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
             },
             new ActEntity {
                Id = Guid.NewGuid().ToString(),
                Name= "Young The Giant",
                ImageUrl = "/src/assets/images/acts/Young_The_Giant/Young_The_Giant.jpg",
                Musicians = new List<MusicianEntity>
                {
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Sameer Gadhia",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[0],
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Jacob Tilley",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[2],
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Eric Cannata",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[1],
                            _instruments[3],
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Payam Doostzadeh",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[4],
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                    new() {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Francois Comtois",
                        Instruments = new List<InstrumentEntity>()
                        {
                            _instruments[6],
                        },
                        IsActive = true,
                        UpdatedAt = DateTime.Now,
                        CreatedAt = DateTime.Now,
                    },
                },
                Type = ActType.Band,
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
             }
        };

        private static readonly List<GenreEntity> _genres = new()
        {
            // 0
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Rock and Roll",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 1
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Pop Rock",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 2
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "R&B",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 3
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Pop Standard",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 4
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Folk",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            //5
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Psychedelic Rock",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 6
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Rap Metal",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 7
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Country",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 8
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Pop",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 9
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Blues",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 10
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Instrumental",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 11
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Soul",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
            // 12
            new GenreEntity
            {
                Id = Guid.NewGuid().ToString(),
                Genre = "Alternative Rock",
                IsActive = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            },
        };
        private static readonly List<AlbumEntity> _albums = new() {
           // The Beatles
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Please Please Me", ActId = _acts[5].Id, Year = 1963, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/Please_Please_Me.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "With the Beatles", ActId =_acts[5].Id, Year = 1963, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/With_the_Beatles.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "A Hard Day's Night", ActId = _acts[5].Id, Year = 1964, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/A_Hard_Days_Night.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Beatles for Sale", ActId = _acts[5].Id, Year = 1964, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/Beatles_for_Sale.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Help!", ActId = _acts[5].Id, Year = 1965, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/Help.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Rubber Soul", ActId = _acts[5].Id, Year = 1965, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/Rubber_Soul.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Revolver", ActId = _acts[5].Id, Year = 1966, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/Revolver.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Sgt. Pepper's Lonely Hearts Club Band", ActId = _acts[5].Id, Year = 1967, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/Sgt_Peppers.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Magical Mystery Tour", ActId = _acts[5].Id, Year = 1967, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/Magical_Mystery_Tour.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "The Beatles (White Album)", ActId = _acts[5].Id, Year = 1968, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/The_White_Album.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Yellow Submarine", ActId = _acts[5].Id, Year = 1969, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/Yellow_Submarine.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Abbey Road", ActId = _acts[5].Id, Year = 1969, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/Abbey_Road.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Let It Be", ActId = _acts[5].Id, Year = 1970, IsActive = true, ImageUrl = "/src/assets/images/albums/The_Beatles/Let_It_Be.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

           // Rage Against the Machine
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Rage Against the Machine", ActId = _acts[4].Id, Year = 1992, IsActive = true, ImageUrl = "/src/assets/images/albums/RATM/Rage_Against_the_Machine.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Evil Empire", ActId = _acts[4].Id, Year = 1996, IsActive = true, ImageUrl = "/src/assets/images/albums/RATM/Evil_Empire.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "The Battle of Los Angeles", ActId = _acts[4].Id, Year = 1999, IsActive = true, ImageUrl = "/src/assets/images/albums/RATM/Battle_of_Los_Angeles.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Renegades", ActId = _acts[4].Id, Year = 2000, IsActive = true, ImageUrl = "/src/assets/images/albums/RATM/Renegades.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

           // Young The Giant
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Young the Giant", ActId = _acts[6].Id, Year = 2010, IsActive = true, ImageUrl = "/src/assets/images/albums/Young_The_Giant/Young_the_Giant.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Mind over Matter", ActId = _acts[6].Id, Year = 2014, IsActive = true, ImageUrl = "/src/assets/images/albums/Young_The_Giant/Mind_over_Matter.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Home of the Strange", ActId = _acts[6].Id, Year = 2016, IsActive = true, ImageUrl = "/src/assets/images/albums/Young_The_Giant/Home_of_the_Strange.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Mirror Master", ActId = _acts[6].Id, Year = 2018, IsActive = true, ImageUrl = "/src/assets/images/albums/Young_The_Giant/Mirror_Master.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "American Bollywood", ActId = _acts[6].Id, Year = 2022, IsActive = true, ImageUrl = "/src/assets/images/albums/Young_The_Giant/American_Bollywood.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
     

           // John Mayer
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Room for Squares", ActId = _acts[0].Id, Year = 2001, IsActive = true, ImageUrl = "/src/assets/images/albums/John_Mayer/Room_for_Squares.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Heavier Things", ActId = _acts[0].Id, Year = 2003, IsActive = true, ImageUrl = "/src/assets/images/albums/John_Mayer/Heavier_Things.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Continuum", ActId = _acts[0].Id, Year = 2006, IsActive = true, ImageUrl = "/src/assets/images/albums/John_Mayer/Continuum.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Battle Studies", ActId = _acts[0].Id, Year = 2009, IsActive = true, ImageUrl = "/src/assets/images/albums/John_Mayer/Battle_Studies.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Born and Raised", ActId = _acts[0].Id, Year = 2012, IsActive = true, ImageUrl = "/src/assets/images/albums/John_Mayer/Born_and_Raised.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Paradise Valley", ActId = _acts[0].Id, Year = 2013, IsActive = true, ImageUrl = "/src/assets/images/albums/John_Mayer/Paradise_Valley.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "The Search for Everything", ActId = _acts[0].Id, Year = 2017, IsActive = true, ImageUrl = "/src/assets/images/albums/John_Mayer/Search_for_Everything.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Sob Rock", ActId = _acts[0].Id, Year = 2021, IsActive = true, ImageUrl = "/src/assets/images/albums/John_Mayer/Sob_Rock.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

           // Mumford and Sons
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Sigh No More", ActId = _acts[1].Id, Year = 2009, IsActive = true, ImageUrl = "/src/assets/images/albums/Mumford_and_Sons/Sigh_No_More.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Babel", ActId = _acts[1].Id, Year = 2012, IsActive = true, ImageUrl = "/src/assets/images/albums/Mumford_and_Sons/Babel.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Wilder Mind", ActId = _acts[1].Id, Year = 2015, IsActive = true, ImageUrl = "/src/assets/images/albums/Mumford_and_Sons/Wilder_Mind.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Delta", ActId = _acts[1].Id, Year = 2018, IsActive = true, ImageUrl = "/src/assets/images/albums/Mumford_and_Sons/Delta.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

           // Led Zeppelin
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Led Zeppelin", ActId = _acts[2].Id, Year = 1969, IsActive = true, ImageUrl = "/src/assets/images/albums/Led_Zeppelin/Led_Zeppelin.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Led Zeppelin II", ActId = _acts[2].Id, Year = 1969, IsActive = true, ImageUrl = "/src/assets/images/albums/Led_Zeppelin/Led_Zeppelin_2.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Led Zeppelin III", ActId = _acts[2].Id, Year = 1970, IsActive = true, ImageUrl = "/src/assets/images/albums/Led_Zeppelin/Led_Zeppelin_3.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Led Zeppelin IV", ActId = _acts[2].Id, Year = 1971, IsActive = true, ImageUrl = "/src/assets/images/albums/Led_Zeppelin/Led_Zeppelin_4.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Houses of the Holy", ActId = _acts[2].Id, Year = 1973, IsActive = true, ImageUrl = "/src/assets/images/albums/Led_Zeppelin/Houses_of_the_Holy.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Physical Graffiti", ActId = _acts[2].Id, Year = 1975, IsActive = true, ImageUrl = "/src/assets/images/albums/Led_Zeppelin/Physical_Graffiti.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Presence", ActId = _acts[2].Id, Year = 1976, IsActive = true, ImageUrl = "/src/assets/images/albums/Led_Zeppelin/Presence.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "In Through the Out Door", ActId = _acts[2].Id, Year = 1979, IsActive = true, ImageUrl = "/src/assets/images/albums/Led_Zeppelin/In_Through_the_Out_Door.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Coda", ActId = _acts[2].Id, Year = 1982, IsActive = true, ImageUrl = "/src/assets/images/albums/Led_Zeppelin/Coda.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

           // Noah Kahan
           new AlbumEntity { Id = Guid.NewGuid().ToString(), Name = "Stick Season", ActId = _acts[3].Id, Year = 2022,IsActive = true, ImageUrl = "/src/assets/images/albums/Noah_Kahan/Stick_Season.jpg", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow}
        };

        private readonly List<SongEntity> _songs = new()
        {
        // Please Please Me (1963)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Saw Her Standing There", Track = 1, Length = 173000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Misery", Track = 2, Length = 109000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Anna (Go to Him)", Track = 3, Length = 176000, Genre = _genres[2], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Chains", Track = 4, Length = 144000, Genre = _genres[2], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Boys", Track = 5, Length = 147000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Ask Me Why", Track = 6, Length = 146000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Please Please Me", Track = 7, Length = 120000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Love Me Do", Track = 8, Length = 143000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "P.S. I Love You", Track = 9, Length = 123000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Baby It's You", Track = 10, Length = 161000, Genre = _genres[2], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Do You Want to Know a Secret", Track = 11, Length = 116000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "A Taste of Honey", Track = 12, Length = 123000, Genre = _genres[3], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "There's a Place", Track = 13, Length = 109000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Twist and Shout", Track = 14, Length = 154000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[0].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

        // With the Beatles (1963)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "It Won't Be Long", Track = 1, Length = 133000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "All I've Got to Do", Track = 2, Length = 124000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "All My Loving", Track = 3, Length = 129000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Don't Bother Me", Track = 4, Length = 148000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Little Child", Track = 5, Length = 107000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Till There Was You", Track = 6, Length = 133000, Genre = _genres[3], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Please Mister Postman", Track = 7, Length = 154000, Genre = _genres[2], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Roll Over Beethoven", Track = 8, Length = 165000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Hold Me Tight", Track = 9, Length = 152000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "You Really Got a Hold on Me", Track = 10, Length = 181000, Genre = _genres[2], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Wanna Be Your Man", Track = 11, Length = 120000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Devil in Her Heart", Track = 12, Length = 147000, Genre = _genres[2], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Not a Second Time", Track = 13, Length = 127000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Money (That's What I Want)", Track = 14, Length = 160000, Genre = _genres[2], Lyrics = "", AlbumId = _albums[1].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

        // A Hard Day's Night (1964)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "A Hard Day's Night", Track = 1, Length = 152000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Should Have Known Better", Track = 2, Length = 163000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "If I Fell", Track = 3, Length = 141000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I'm Happy Just to Dance with You", Track = 4, Length = 116000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "And I Love Her", Track = 5, Length = 150000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Tell Me Why", Track = 6, Length = 129000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Can't Buy Me Love", Track = 7, Length = 138000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Any Time at All", Track = 8, Length = 131000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I'll Cry Instead", Track = 9, Length = 106000, Genre = _genres[7], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Things We Said Today", Track = 10, Length = 155000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "When I Get Home", Track = 11, Length = 137000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "You Can't Do That", Track = 12, Length = 155000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I'll Be Back", Track = 13, Length = 145000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[2].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

        // Beatles for Sale (1964)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "No Reply", Track = 1, Length = 136000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I'm a Loser", Track = 2, Length = 145000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Baby's in Black", Track = 3, Length = 125000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Rock and Roll Music", Track = 4, Length = 132000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I'll Follow the Sun", Track = 5, Length = 108000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Mr. Moonlight", Track = 6, Length = 155000, Genre = _genres[2], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Kansas City/Hey-Hey-Hey-Hey!", Track = 7, Length = 154000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Eight Days a Week", Track = 8, Length = 168000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Words of Love", Track = 9, Length = 122000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Honey Don't", Track = 10, Length = 176000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Every Little Thing", Track = 11, Length = 124000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Don't Want to Spoil the Party", Track = 12, Length = 153000, Genre = _genres[7], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "What You're Doing", Track = 13, Length = 150000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Everybody's Trying to Be My Baby", Track = 14, Length = 144000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[3].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

        // Help! (1965)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Help!", Track = 1, Length = 138000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "The Night Before", Track = 2, Length = 153000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "You've Got to Hide Your Love Away", Track = 3, Length = 132000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Need You", Track = 4, Length = 148000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Another Girl", Track = 5, Length = 125000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "You're Going to Lose That Girl", Track = 6, Length = 138000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Ticket to Ride", Track = 7, Length = 191000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Act Naturally", Track = 8, Length = 149000, Genre = _genres[7], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "It's Only Love", Track = 9, Length = 116000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "You Like Me Too Much", Track = 10, Length = 156000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Tell Me What You See", Track = 11, Length = 158000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I've Just Seen a Face", Track = 12, Length = 124000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Yesterday", Track = 13, Length = 125000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Dizzy Miss Lizzy", Track = 14, Length = 169000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[4].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

        // Rubber Soul (1965)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Drive My Car", Track = 1, Length = 145000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Norwegian Wood (This Bird Has Flown)", Track = 2, Length = 125000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "You Won't See Me", Track = 3, Length = 199000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Nowhere Man", Track = 4, Length = 164000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Think for Yourself", Track = 5, Length = 139000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "The Word", Track = 6, Length = 163000, Genre = _genres[11], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Michelle", Track = 7, Length = 162000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "What Goes On", Track = 8, Length = 169000, Genre = _genres[7], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Girl", Track = 9, Length = 151000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I'm Looking Through You", Track = 10, Length = 146000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "In My Life", Track = 11, Length = 145000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Wait", Track = 12, Length = 136000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "If I Needed Someone", Track = 13, Length = 140000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Run for Your Life", Track = 14, Length = 138000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[5].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

        // Revolver (1966)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Taxman", Track = 1, Length = 159000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Eleanor Rigby", Track = 2, Length = 126000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I'm Only Sleeping", Track = 3, Length = 181000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Love You To", Track = 4, Length = 180000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Here, There and Everywhere", Track = 5, Length = 144000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Yellow Submarine", Track = 6, Length = 158000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "She Said She Said", Track = 7, Length = 157000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Good Day Sunshine", Track = 8, Length = 129000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "And Your Bird Can Sing", Track = 9, Length = 120000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "For No One", Track = 10, Length = 121000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Doctor Robert", Track = 11, Length = 135000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Want to Tell You", Track = 12, Length = 149000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Got to Get You Into My Life", Track = 13, Length = 147000, Genre = _genres[11], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Tomorrow Never Knows", Track = 14, Length = 177000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[6].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

        // Sgt. Pepper's Lonely Hearts Club Band (1967)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Sgt. Pepper's Lonely Hearts Club Band", Track = 1, Length = 122000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "With a Little Help from My Friends", Track = 2, Length = 164000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Lucy in the Sky with Diamonds", Track = 3, Length = 208000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Getting By", Track = 4, Length = 158000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Fixing a Hole", Track = 5, Length = 156000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "She's Leaving Home", Track = 6, Length = 215000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Being for the Benefit of Mr. Kite!", Track = 7, Length = 157000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Within You Without You", Track = 8, Length = 305000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "When I'm Sixty-Four", Track = 9, Length = 157000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Lovely Rita", Track = 10, Length = 162000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Good Morning Good Morning", Track = 11, Length = 161000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Sgt. Pepper's Lonely Hearts Club Band (Reprise)", Track = 12, Length = 79000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "A Day in the Life", Track = 13, Length = 337000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[7].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

        // Magical Mystery Tour (1967)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Magical Mystery Tour", Track = 1, Length = 168000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "The Fool on the Hill", Track = 2, Length = 180000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Flying", Track = 3, Length = 137000, Genre = _genres[10], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Blue Jay Way", Track = 4, Length = 216000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Your Mother Should Know", Track = 5, Length = 148000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Am the Walrus", Track = 6, Length = 267000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Hello, Goodbye", Track = 7, Length = 207000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Strawberry Fields Forever", Track = 8, Length = 247000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Penny Lane", Track = 9, Length = 180000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Baby, You're a Rich Man", Track = 10, Length = 180000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "All You Need Is Love", Track = 11, Length = 237000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[8].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

        // The Beatles (White Album) (1968) - Disc 1
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Back in the U.S.S.R.", Track = 1, Length = 163000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Dear Prudence", Track = 2, Length = 229000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Glass Onion", Track = 3, Length = 138000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Ob-La-Di, Ob-La-Da", Track = 4, Length = 188000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Wild Honey Pie", Track = 5, Length = 52000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "The Continuing Story of Bungalow Bill", Track = 6, Length = 193000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "While My Guitar Gently Weeps", Track = 7, Length = 285000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Happiness Is a Warm Gun", Track = 8, Length = 163000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Martha My Dear", Track = 9, Length = 148000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I'm So Tired", Track = 10, Length = 123000, Genre = _genres[9], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Blackbird", Track = 11, Length = 138000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Piggies", Track = 12, Length = 124000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Rocky Raccoon", Track = 13, Length = 203000, Genre = _genres[7], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Don't Pass Me By", Track = 14, Length = 231000, Genre = _genres[7], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Why Don't We Do It in the Road?", Track = 15, Length = 101000, Genre = _genres[9], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Will", Track = 16, Length = 106000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Julia", Track = 17, Length = 175000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        // Disc 2
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Birthday", Track = 18, Length = 168000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Yer Blues", Track = 19, Length = 240000, Genre = _genres[9], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Mother Nature's Son", Track = 20, Length = 167000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Everybody's Got Something to Hide Except Me and My Monkey", Track = 21, Length = 144000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Sexy Sadie", Track = 22, Length = 195000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Helter Skelter", Track = 23, Length = 269000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Long, Long, Long", Track = 24, Length = 195000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Revolution 1", Track = 25, Length = 262000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Honey Pie", Track = 26, Length = 161000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Savoy Truffle", Track = 27, Length = 168000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Cry Baby Cry", Track = 28, Length = 185000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Revolution 9", Track = 29, Length = 487000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Good Night", Track = 30, Length = 211000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[9].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

           // Yellow Submarine (1969)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Yellow Submarine", Track = 1, Length = 158000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[10].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Only a Northern Song", Track = 2, Length = 205000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[10].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "All Together Now", Track = 3, Length = 130000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[10].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Hey Bulldog", Track = 4, Length = 193000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[10].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "It's All Too Much", Track = 5, Length = 386000, Genre = _genres[5], Lyrics = "", AlbumId = _albums[10].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "All You Need Is Love", Track = 6, Length = 237000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[10].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

        // Abbey Road (1969)
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Come Together", Track = 1, Length = 259000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Something", Track = 2, Length = 182000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Maxwell's Silver Hammer", Track = 3, Length = 207000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Oh! Darling", Track = 4, Length = 206000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Octopus's Garden", Track = 5, Length = 171000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Want You (She's So Heavy)", Track = 6, Length = 467000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Here Comes the Sun", Track = 7, Length = 185000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Because", Track = 8, Length = 165000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "You Never Give Me Your Money", Track = 9, Length = 226000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Sun King", Track = 10, Length = 166000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Mean Mr. Mustard", Track = 11, Length = 66000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Polythene Pam", Track = 12, Length = 72000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "She Came in Through the Bathroom Window", Track = 13, Length = 117000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Golden Slumbers", Track = 14, Length = 91000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Carry That Weight", Track = 15, Length = 96000, Genre = _genres[1], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "The End", Track = 16, Length = 140000, Genre = _genres[0], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
        new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Her Majesty", Track = 17, Length = 23000, Genre = _genres[8], Lyrics = "", AlbumId = _albums[11].Id, ActId = _acts[5].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},

            // Rage Against the Machine (1992)
            new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Bombtrack", Track = 1, Length = 242000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[13].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Killing in the Name", Track = 2, Length = 314000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[13].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
            new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Take the Power Back", Track = 3, Length = 334000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[13].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Settle for Nothing", Track = 4, Length = 287000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[13].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Bullet in the Head", Track = 5, Length = 321000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[13].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Know Your Enemy", Track = 6, Length = 297000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[13].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Wake Up", Track = 7, Length = 376000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[13].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Fistful of Steel", Track = 8, Length = 331000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[13].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Township Rebellion", Track = 9, Length = 315000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[13].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Freedom", Track = 10, Length = 366000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[13].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           // Evil Empire (1996)
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "People of the Sun", Track = 1, Length = 140000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Bulls on Parade", Track = 2, Length = 228000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Vietnow", Track = 3, Length = 267000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Revolver", Track = 4, Length = 330000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Snakecharmer", Track = 5, Length = 218000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Tire Me", Track = 6, Length = 180000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Down Rodeo", Track = 7, Length = 324000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Without a Face", Track = 8, Length = 341000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Wind Below", Track = 9, Length = 318000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Roll Right", Track = 10, Length = 266000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Year of tha Boomerang", Track = 11, Length = 240000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[14].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           // The Battle of Los Angeles (1999)
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Testify", Track = 1, Length = 210000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Guerrilla Radio", Track = 2, Length = 206000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Calm Like a Bomb", Track = 3, Length = 298000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Mic Check", Track = 4, Length = 213000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Sleep Now in the Fire", Track = 5, Length = 205000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Born of a Broken Man", Track = 6, Length = 281000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Born as Ghosts", Track = 7, Length = 205000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Maria", Track = 8, Length = 219000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Voice of the Voiceless", Track = 9, Length = 143000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "New Millennium Homes", Track = 10, Length = 221000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Ashes in the Fall", Track = 11, Length = 278000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "War Within a Breath", Track = 12, Length = 227000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[15].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           // Renegades (2000) - Cover album
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Microphone Fiend", Track = 1, Length = 300000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Pistol Grip Pump", Track = 2, Length = 197000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Kick Out the Jams", Track = 3, Length = 197000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Renegades of Funk", Track = 4, Length = 326000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Beautiful World", Track = 5, Length = 154000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I'm Housin'", Track = 6, Length = 288000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "In My Eyes", Track = 7, Length = 166000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "How I Could Just Kill a Man", Track = 8, Length = 261000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "The Ghost of Tom Joad", Track = 9, Length = 322000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Down on the Street", Track = 10, Length = 227000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Street Fighting Man", Track = 11, Length = 283000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Maggie's Farm", Track = 12, Length = 405000, Genre = _genres[6], Lyrics = "", AlbumId = _albums[16].Id, ActId = _acts[4].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           // Stick Season (2024)
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Northern Attitude", Track = 1, Length = 218000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Stick Season", Track = 2, Length = 201000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "All My Love", Track = 3, Length = 237000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
           new SongEntity { Id = Guid.NewGuid().ToString(), Name = "She Calls Me Back", Track = 4, Length = 224000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Come Over", Track = 5, Length = 189000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "New Perspective", Track = 6, Length = 247000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Everywhere, Everything", Track = 7, Length = 258000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Orange Juice", Track = 8, Length = 213000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Strawberry Wine", Track = 9, Length = 267000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Growing Sideways", Track = 10, Length = 235000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Halloween", Track = 11, Length = 204000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Homesick", Track = 12, Length = 278000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Still", Track = 13, Length = 189000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "The View Between Villages", Track = 14, Length = 240000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[43].Id, ActId = _acts[3].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          // Sigh No More (2009)
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Sigh No More", Track = 1, Length = 264000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "The Cave", Track = 2, Length = 261000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Winter Winds", Track = 3, Length = 324000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Roll Away Your Stone", Track = 4, Length = 265000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "White Blank Page", Track = 5, Length = 293000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Gave You All", Track = 6, Length = 305000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Little Lion Man", Track = 7, Length = 248000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Timshel", Track = 8, Length = 309000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Thistle & Weeds", Track = 9, Length = 295000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Awake My Soul", Track = 10, Length = 332000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Dust Bowl Dance", Track = 11, Length = 262000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "After the Storm", Track = 12, Length = 287000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[31].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          // Babel (2012)
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Babel", Track = 1, Length = 213000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Whispers in the Dark", Track = 2, Length = 234000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "I Will Wait", Track = 3, Length = 277000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Holland Road", Track = 4, Length = 276000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Ghosts That We Knew", Track = 5, Length = 297000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Lover of the Light", Track = 6, Length = 321000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Lovers' Eyes", Track = 7, Length = 252000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Reminder", Track = 8, Length = 252000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Hopeless Wanderer", Track = 9, Length = 302000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Broken Crown", Track = 10, Length = 256000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Below My Feet", Track = 11, Length = 276000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Not with Haste", Track = 12, Length = 250000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[32].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          // Wilder Mind (2015)
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Tompkins Square Park", Track = 1, Length = 251000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Believe", Track = 2, Length = 222000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "The Wolf", Track = 3, Length = 255000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Wilder Mind", Track = 4, Length = 248000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Just Smoke", Track = 5, Length = 281000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Monster", Track = 6, Length = 249000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Snake Eyes", Track = 7, Length = 260000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Broad-Shouldered Beasts", Track = 8, Length = 278000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Cold Arms", Track = 9, Length = 222000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Ditmas", Track = 10, Length = 267000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name="Only Love", Track = 11, Length = 264000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Hot Gates", Track = 12, Length = 327000, Genre = _genres[12], Lyrics = "", AlbumId = _albums[33].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          // Delta (2018)
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "42", Track = 1, Length = 268000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Guiding Light", Track = 2, Length = 242000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "If I Say", Track = 3, Length = 233000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Beloved", Track = 4, Length = 243000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "The Wild", Track = 5, Length = 257000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "October Skies", Track = 6, Length = 265000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Slip Away", Track = 7, Length = 225000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Rose of Sharon", Track = 8, Length = 211000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Picture You", Track = 9, Length = 255000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Darkness Visible", Track = 10, Length = 283000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Woman", Track = 11, Length = 317000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Wild Heart", Track = 12, Length = 278000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
          new SongEntity { Id = Guid.NewGuid().ToString(), Name = "Delta", Track = 13, Length = 257000, Genre = _genres[4], Lyrics = "", AlbumId = _albums[34].Id, ActId = _acts[1].Id, IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
        };

        // public static List<ActEntity> _acts { get => __acts; set => __acts = value; }

        public DataSeeder(DataContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            foreach (InstrumentEntity i in _instruments)
            {
                _context.Instruments.Add(i);
            }

            foreach (ActEntity a in _acts)
            {
                _context.Acts.Add(a);
            }

            foreach (GenreEntity g in _genres)
            {
                _context.Genres.Add(g);
            }

            foreach (AlbumEntity al in _albums)
            {
                _context.Albums.Add(al);
            }

            foreach (SongEntity s in _songs)
            {
                _context.Songs.Add(s);
            }

            _context.SaveChanges();
        }
    }
}

// List indexes

// ** Instruments **
//0 "Lead Vocals"
//1 "Background Vocals"
//2 "Lead Guitar"
//3 "Rhythm Guitar"
//4 "Bass Guitar"
//5 "Keyboard"
//6 "Drums"

// ** Musician **
//0 "John Mayer"
//1 "Mumford and Sons"
//2 "Led Zeppelin"
//3 "Noah Kahan"
//4 "Rage Against the Machine"
//5 "The Beatles"
//6 "Young The Giant"

// ** Albums **
//0 "Please Please Me"
//1 "With the Beatles"
//2 "A Hard Day's Night"
//3 "Beatles for Sale"
//4 "Help!"  
//5 "Rubber Soul" 
//6 "Revolver"  
//7 "Sgt. Pepper's Lonely Hearts Club Band"
//8 "Magical Mystery Tour"5].
//9 "The Beatles (White Album)" 
//10"Yellow Submarine"
//11"Abbey Road" 
//12"Let It Be" 
//13"Rage Against the Machine" 
//14"Evil Empire"
//15"The Battle of Los Angeles" 
//16"Renegades"
//17"Young the Giant"
//18"Mind over Matter"
//19"Home of the Strange"
//20"Mirror Master"
//21"American Bollywood"
//22"Act Your Age"
//23"Room for Squares"
//24"Heavier Things"
//25"Continuum"
//26"Battle Studies"
//27"Born and Raised"
//28"Paradise Valley"
//29"The Search for Everything" 
//30"Sob Rock"
//31"Sigh No More"
//32"Babel"
//33"Wilder Mind"
//34"Delta"
//35"Led Zeppelin"
//36"Led Zeppelin II"
//37"Led Zeppelin III" 
//38"Led Zeppelin IV"
//39"Houses of the Holy"
//40"Physical Graffiti"
//41"Presence"
//42"In Through the Out Door"
//43"Coda"
//44"Stick Season"

//Table Album
//{
//    id varchar [primary key]
//    title varchar
//  actId varchar [Ref: - Act.id]
//    isActive bool 
//  createdat timestamp
//  updatedat timestamp
//}

//Table Act
//{
//    id varchar [primary key]
//    musicians varchar [Ref: < Musician.id]
//    name varchar
//  type int 
//    isActive bool 
//    createdat timestamp
//  updatedat timestamp
//}

//Table Musician
//{
//    id varchar [primary key]
//    name varchar
//  instruments varchar [Ref: < Instrument.id]
//    isActive bool 
//      createdat timestamp
//  updatedat timestamp
//}

//Table Instrument
//{
//    id varchar [primary key]
//    name varchar
//}

//Table Song
//{
//    id varchar [primary key]
//    actId varchar [Ref: - Act.id]
//    albumId varchar [Ref: - Album.id]
//    title varchar
//  track int 
//          length int 
//          genre varchar
//  lyrics varchar
//  isActive bool 
//          createdat timestamp
//  updatedat timestamp
//}