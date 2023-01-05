using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaDbFirst.Models
{
    public partial class TblDirector
    {
        public TblDirector()
        {
            TblMovies = new HashSet<TblMovie>();
        }

        public int Id { get; set; }
        public string DirectorName { get; set; }

        public virtual ICollection<TblMovie> TblMovies { get; set; }
    }
}
