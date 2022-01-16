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
        public string ProducerProfilePictureURL { get; set; }
        public string ProducerFullName { get; set; }
        public string ProducerBio { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
