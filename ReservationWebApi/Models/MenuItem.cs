using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWebApi.Models
{
    public class MenuItem
    {
        [Key]
        public int M_Id { get; set; }
        public string M_name { get; set; }
        public double M_price { get; set; }
    }
}
