using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class Promo
    {
        public int pr_Id { get; set; }

        [Required]
        [Display(Name = "Promo Code")]
        public string promoCode { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime startDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime endDate { get; set; }

        [Required]
        [Display(Name = "Discount")]
        public string Discount { get; set; }

        [Required]
        [Display(Name = "Max Amount")]
        public Double maxAmount { get; set; }


    }
}
