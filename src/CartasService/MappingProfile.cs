using AutoMapper;
using CartasService.Models;
using CartasService.Models.DTOs;


namespace CartasService;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Carta, CartaDto>().ReverseMap();
        CreateMap<Poder, PoderDto>().ReverseMap();
        CreateMap<CreateCardDto, Carta>();
    }
}
