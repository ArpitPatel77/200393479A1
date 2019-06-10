using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _200393479A1.Models
{
    public class Genre
    {
        public virtual int Genreid { get; set; }

        [Required]
        public virtual string Name { get; set; }

        [Required]
        public virtual string Description { get; set; }

        public virtual List<videoGame> videoGames { get; set; }
    }
}