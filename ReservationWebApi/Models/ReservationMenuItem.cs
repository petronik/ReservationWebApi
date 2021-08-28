using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWebApi.Models
{
    public class ReservationMenuItem
    {
        [Key]
        public int Rm_Id { get; set; }
        [ForeignKey("Reservation")]
        public int Reservation_Id { get; set; }
        public Reservation Reservation { get; set; }
        [ForeignKey("MenuItem")]
        public int MenuItem_Id { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
