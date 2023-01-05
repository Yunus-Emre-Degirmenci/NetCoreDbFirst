using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaDbFirst.Models
{
    public partial class TblMovie
    {
        public TblMovie()
        {
            TblMovieActors = new HashSet<TblMovieActor>();
        }

        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public int DirectorId { get; set; }
        public int CategoryId { get; set; }
        public DateTime? Date { get; set; }

        public virtual TblCategory Category { get; set; }
        public virtual TblDirector Director { get; set; }
        public virtual ICollection<TblMovieActor> TblMovieActors { get; set; }
    }
}
