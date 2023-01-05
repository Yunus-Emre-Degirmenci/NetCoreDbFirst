using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaDbFirst.Models
{
    public partial class TblActor
    {
        public TblActor()
        {
            TblMovieActors = new HashSet<TblMovieActor>();
        }

        public int Id { get; set; }
        public string ActorName { get; set; }

        public virtual ICollection<TblMovieActor> TblMovieActors { get; set; }
    }
}
