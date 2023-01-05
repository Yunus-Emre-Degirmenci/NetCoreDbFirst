using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaDbFirst.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblMovies = new HashSet<TblMovie>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<TblMovie> TblMovies { get; set; }
    }
}
