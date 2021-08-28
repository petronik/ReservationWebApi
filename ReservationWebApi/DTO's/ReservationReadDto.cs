﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWebApi.DTO_s
{
    public class ReservationReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<MenuItemReadDto> MenuItems { get; set; }
    }
}
