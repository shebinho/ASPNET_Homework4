using SEDC.MusicManager.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SEDC.MusicManager.Repo
{
    public class MusicDb : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }
    }
}
