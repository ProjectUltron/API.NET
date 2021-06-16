using API.NET.Domain.Models;
using API.NET.Resources;
using AutoMapper;

namespace API.NET.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
