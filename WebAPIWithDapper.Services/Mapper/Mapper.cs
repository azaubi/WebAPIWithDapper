using AutoMapper;
using WebAPIWithDapper.Core.Dtos;
using WebAPIWithDapper.Data.Models;

namespace WebAPIWithDapper.Services.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            Initialize();
        }

        public void Initialize()
        {
            CreateMap<Property, PropertyDto>().ReverseMap();
            CreateMap<Resident, ResidentDto>().ReverseMap();
        }
    }
}
