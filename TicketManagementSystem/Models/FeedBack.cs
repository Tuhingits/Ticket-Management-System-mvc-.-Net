using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManagementSystem.Models
{
    public class FeedBack
    {
        [Key]
        public int fb_Id { get; set; }

        [Required]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Required]
        [Display(Name = "Details Filter")]
        public string Filter { get; set; }

        public Cart Cart { get; set; }
        public User User { get; set; }
    }
}
