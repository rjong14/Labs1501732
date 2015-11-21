using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace _1.MVCEntity.Models {
    public class Song {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }   //DONE already
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
        public string Singer { get; set; }
        public string SongWriter { get; set; }
    }

    public class SongDBContext : DbContext {
        public DbSet<Song> Playlist { get; set; }
    }
}