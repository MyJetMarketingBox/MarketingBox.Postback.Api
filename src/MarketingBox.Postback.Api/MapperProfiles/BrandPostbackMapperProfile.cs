using AutoMapper;
using MarketingBox.Postback.Api.Models;
using MarketingBox.Postback.Service.Domain.Models;
using MarketingBox.Postback.Service.Domain.Models.Requests;

namespace MarketingBox.Postback.Api.MapperProfiles
{
    public class BrandPostbackMapperProfile : Profile
    {
        public BrandPostbackMapperProfile()
        {
            CreateMap<BrandPostbackRequestModel, BrandPostbackRequest>();
            CreateMap<GeneralInfoModel, GeneralInfo>();
            CreateMap<AdditionalInfoModel, AdditionalInfo>();
            CreateMap<RegistrationBrandInfoModel, RegistrationBrandInfo>();
        }
    }
}