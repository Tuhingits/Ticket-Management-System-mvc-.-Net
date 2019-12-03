using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class Cart
    {
        [Key]
        public int C_Id { get; set; }

        [Required]
        [Display(Name = "Date")]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Total Amount ")]
        public string TotalTk { get; set; }

        public Registation Registation { get; set; }
        public Promo Promo { get; set; }
        public Launch Launch { get; set; }

        public  ICollection<Registation>  Registations { get; set; }
        public  ICollection<Launch> Launches { get; set; }
        public  ICollection<Promo> Promos { get; set; }

    }
}
