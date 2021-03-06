using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        [Display(Name ="Actor's Photo")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Actor's Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Actor's Biography")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
