using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikUICoreDemo.Models
{
    public class cmDealer
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Balance { get; set; }
        public string Email { get; set; }
        public string EditUrl { get; set; }
    }
}
