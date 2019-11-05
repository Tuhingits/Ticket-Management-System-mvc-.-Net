using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class CavinDetails

    {
        [Key]
        public int cv_Id { get; set; }

        [Required]
        [Display(Name = "Cavin Catagory")]
        public string CavinCatagory { get; set; }

        [Required]
        [Display(Name = "Cavin Rent")]
        public Double Rent { get; set; }

        [Required]
        [Display(Name = "Cavin Position")]
        public string Position { get; set; }

        [Required]
        [Display(Name = "Cavin Number")]
        public string CavinNumber { get; set; }

        public Launch Launch { get; set; }
    }
}
