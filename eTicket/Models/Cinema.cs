using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaID { get; set; }
        [Display(Name ="Logo")]
        public string LogoURL { get; set; }
        [Display(Name = "Cinema Name")]
        public string CinemaName { get; set; }
        [Display(Name = "Description")]
        public string CinemaDescription{ get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
