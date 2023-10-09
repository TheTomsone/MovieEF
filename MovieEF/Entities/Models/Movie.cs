using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEF.Entities.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseDate { get; set; }
        public string Maker { get; set; }
        public string MainActor { get; set; }
        public string Genre { get; set; }
    }
}
