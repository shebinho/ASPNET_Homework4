﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.MusicManager.Data
{
    public class Artist
    {   
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public ArtistType ArtistType { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
