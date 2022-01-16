using eTicket.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieName{ get; set; }
        public string MovieDesc { get; set; }
        public string MovieURL { get; set; }
        public double MoviePrice { get; set; }
        public DateTime MoiveStartDate { get; set; }
        public DateTime MovieEndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //relatioship
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }

    }
}
