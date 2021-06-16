using API.NET.Domain.Models;
using API.NET.Resources;
using AutoMapper;

namespace API.NET.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}
