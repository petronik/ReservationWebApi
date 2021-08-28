using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWebApi.Models
{
    public class Reservation
    {
        [Key]
        public int R_Id { get; set; }
        public string R_Name { get; set; }
        public DateTime R_Date { get; set; }
    }
}
