using System;
using System.ComponentModel.DataAnnotations;

namespace TelerikUICoreDemo.Models
{
    public class CallListDto
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime CallStartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime LastCallDate { get; set; }
        [DataType(DataType.Url)]
        public string CallSheet { get; set; }

    }
}
