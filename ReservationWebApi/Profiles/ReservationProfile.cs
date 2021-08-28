using AutoMapper;
using ReservationWebApi.DTO_s;
using ReservationWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWebApi.Profiles
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<Reservation, ReservationCreateDto>();
            CreateMap<ReservationCreateDto, Reservation>();

            CreateMap<Reservation, ReservationReadDto>();
            CreateMap<ReservationReadDto, Reservation>();
        }
    }
}
