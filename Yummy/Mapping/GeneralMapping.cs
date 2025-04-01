using AutoMapper;
using Yummy.Dtos.FeatureDto;
using Yummy.Dtos.MessageDto;
using Yummy.Dtos.ProductDto;
using Yummy.Entities;

namespace Yummy.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            //Feature
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            //message
            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessageDto>().ReverseMap();

            //product
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, ResutlProductWithCategoryDto>().ForMember(x => x.CategoryName, y => y.MapFrom(z => z.Category.CategoryName)).ReverseMap();
        }
    }
}
