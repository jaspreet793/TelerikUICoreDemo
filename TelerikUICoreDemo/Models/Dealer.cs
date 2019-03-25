using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikUICoreDemo.Models
{
    public class Dealer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        public string EditUrl { get; set; }
    }
}
