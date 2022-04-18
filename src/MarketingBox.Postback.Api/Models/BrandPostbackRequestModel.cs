using System.ComponentModel.DataAnnotations;
using Destructurama.Attributed;
using MarketingBox.Postback.Service.Domain.Models;
using MarketingBox.Sdk.Common.Attributes;
using MarketingBox.Sdk.Common.Enums;
using CountryCodeType = MarketingBox.Sdk.Common.Enums.CountryCodeType;

namespace MarketingBox.Postback.Api.Models
{
    public class BrandPostbackRequestModel
    {
        [Required]
        public BrandEventType? EventType { get; set; }
        
        [Required]
        public GeneralInfoModel GeneralInfo { get; set; }

        public CrmStatus? CrmStatus { get; set; }

        public AdditionalInfoModel AdditionalInfo { get; set; }
        
        public RegistrationBrandInfoModel RegistrationBrandInfo { get; set; }
    }

    public class GeneralInfoModel
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string LastName { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 6)]
        [LogMasked(PreserveLength = true)]
        public string Password { get; set; }

        [Required]
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string Email { get; set; }

        [Phone, StringLength(20, MinimumLength = 7)]
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string Phone { get; set; }

        [Required]
        [Phone, StringLength(15, MinimumLength = 7)]
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string Ip { get; set; }
       
        [Required]
        public CountryCodeType? CountryCodeType { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 2)]
        public string CountryCode { get; set; }
    }
    
    public class AdditionalInfoModel
    {
        public string Sub1 { get; set; }

        public string Sub2 { get; set; }

        public string Sub3 { get; set; }

        public string Sub4 { get; set; }

        public string Sub5 { get; set; }

        public string Sub6 { get; set; }

        public string Sub7 { get; set; }

        public string Sub8 { get; set; }

        public string Sub9 { get; set; }

        public string Sub10 { get; set; }

        public string Funnel { get; set; }

        public string AffCode { get; set; }
    }
    
    public class RegistrationBrandInfoModel
    {
        public string CustomerId { get; set; }

        public string Token { get; set; }

        public string LoginUrl { get; set; }

        public string Brand { get; set; }
    }
}