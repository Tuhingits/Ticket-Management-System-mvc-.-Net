using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class Launch
    {
        [Key]
        public int l_Id { get; set; }

        [Required]
        [Display(Name = "Launch Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Rout")]
        public string Rout { get; set; }
    }
}
