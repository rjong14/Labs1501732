using System;
using System.Data.Entity;

namespace _1.MVCEntity.Models {
    public class Song {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Singer { get; set; }
        public string SongWriter { get; set; }
    }

    public class SongDBContext : DbContext {
        public DbSet<Song> Playlist { get; set; }
    }
}