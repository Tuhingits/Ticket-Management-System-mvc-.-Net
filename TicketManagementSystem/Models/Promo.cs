using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class Promo
    {
        [Key]
        public int Pr_Id { get; set; }

        [Required]
        [Display(Name = "Promo Code")]
        public string PromoCode { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Discount")]
        public string Discount { get; set; }

        [Required]
        [Display(Name = "Maxumam Amount")]
        public Double MaxAmount { get; set; }

        public ICollection<Promo> Promos { get; set; }

    }
}
