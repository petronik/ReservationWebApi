using AutoMapper;
using ReservationWebApi.DTO_s;
using ReservationWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWebApi.Profiles
{
    public class MenuItemProfile : Profile
    {
        public MenuItemProfile()
        {
            CreateMap<MenuItem, MenuItemCreateDto>();
            CreateMap<MenuItemCreateDto, MenuItem>();

            CreateMap<MenuItem, MenuItemReadDto>();
            CreateMap<MenuItemReadDto, MenuItem>();
        }
    }
}
