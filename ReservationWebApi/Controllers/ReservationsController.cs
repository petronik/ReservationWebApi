using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReservationWebApi.Data;
using ReservationWebApi.DTO_s;
using ReservationWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReservationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ReservationsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<ReservationsController>
        [HttpGet]
        public ActionResult Get()
        {
            var reservation = _context.Reservations
                .Select(r => new ReservationReadDto
                {
                    Id = r.R_Id,
                    Name = r.R_Name,
                    Date = r.R_Date,
                    MenuItems = _context.ReservationMenuItem
                    .Where(rm => rm.Reservation_Id == r.R_Id)
                    .Select(m => new MenuItemReadDto
                    {
                        Id = m.MenuItem.M_Id,
                        Name = m.MenuItem.M_name,
                        Price = m.MenuItem.M_price
                    })
                    .ToList()

                });


            return Ok();
        }

        // GET api/<ReservationsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var reservation = _context.Reservations
                .Where(r => r.R_Id == id)
                .Select(r => new ReservationReadDto
                {
                    Id = r.R_Id,
                    Name = r.R_Name,
                    Date = r.R_Date,
                    MenuItems = _context.ReservationMenuItem
                        .Where(rm => rm.Reservation_Id == r.R_Id)
                        .Select(m => new MenuItemReadDto
                        {
                            Id = m.MenuItem.M_Id,
                            Name = m.MenuItem.M_name,
                            Price = m.MenuItem.M_price
                        })
                        .ToList()
                })
                .FirstOrDefault();

            if (reservation == null)
                return NotFound($"Order with id={id} doesn't exist.");


            return Ok("value");
        }

        // POST api/<ReservationsController>
        [HttpPost]
        public ActionResult Post([FromBody] ReservationCreateDto value)
        {
            var newResrvation = _mapper.Map<Reservation>(value);
            _context.Reservations.Add(newResrvation);
            _context.SaveChanges();

            foreach(var id in value.ReservationId)
            {
                ReservationMenuItem rm = new ReservationMenuItem
                {
                    Reservation_Id = newResrvation.R_Id,
                    MenuItem_Id = id
                };
                _context.ReservationMenuItem.Add(rm);
            }
            _context.SaveChanges();
            return Ok();
        }

        // PUT api/<ReservationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
