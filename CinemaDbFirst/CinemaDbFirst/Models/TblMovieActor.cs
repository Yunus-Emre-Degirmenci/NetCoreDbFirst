using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaDbFirst.Models
{
    public partial class TblMovieActor
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        public virtual TblActor Actor { get; set; }
        public virtual TblMovie Movie { get; set; }
    }
}
