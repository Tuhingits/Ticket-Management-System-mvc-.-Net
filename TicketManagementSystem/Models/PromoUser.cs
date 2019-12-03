using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class PromoUser
    {
        [Key]
        public int PU_Id { get; set; }

        [Required]
        [Display(Name = "Date")]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Time")]
        public string Time { get; set; }

       public Registation Registation { get; set; }
        public Promo Promo { get; set; }

        public ICollection<Registation> Registations { get; set; }
        public ICollection<Promo>Promos { get; set; }

    }
}
