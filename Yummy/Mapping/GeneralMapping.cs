using AutoMapper;
using Yummy.Dtos.FeatureDto;
using Yummy.Dtos.MessageDto;
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
        }
    }
}
