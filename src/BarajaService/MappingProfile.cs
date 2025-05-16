using System;
using AutoMapper;
using BarajaService.Models;
using BarajaService.Models.DTOs;

namespace BarajaService;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Baraja, BarajaDTO>().ReverseMap();
        CreateMap<Carta, CartaDTO>().ReverseMap();
        CreateMap<CrearBarajaDTO, Baraja>();
    }
}
