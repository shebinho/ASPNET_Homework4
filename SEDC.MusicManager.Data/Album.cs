using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.MusicManager.Data
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public GenreType GenreType { get; set; }

        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual ICollection<Song> Songs { get; set; }


    }
}
