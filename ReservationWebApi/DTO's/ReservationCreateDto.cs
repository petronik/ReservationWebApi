using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWebApi.DTO_s
{
    public class ReservationCreateDto
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<int> ReservationId { get; set; }

    }
}
