using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class Owner
    {
        public int o_Id { get; set; }

        [Required]
        [Display(Name = "Owner Name")]
        public string ownerName { get; set; }

        [Required]
        [Display(Name = "Owner Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Owner Phone Number")]
        public string Phone { get; set; }

        public Launch Launch { get; set; }
    }
}
