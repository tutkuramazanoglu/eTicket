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
        public string LogoURL { get; set; }
        public string CinemaName { get; set; }
        public string CinemaDescription{ get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
