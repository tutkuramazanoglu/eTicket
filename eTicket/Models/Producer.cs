using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Models
{
    public class Producer
    {
        [Key]
        public int ProducerID { get; set; }
        [Display(Name = "Producer's Photo")]
        public string ProducerProfilePictureURL { get; set; }
        [Display(Name = "Producer's Full Name")]
        public string ProducerFullName { get; set; }
        [Display(Name = "Producer's Bio")]
        public string ProducerBio { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
