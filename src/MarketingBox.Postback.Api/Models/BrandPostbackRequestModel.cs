using System.ComponentModel.DataAnnotations;
using Destructurama.Attributed;
using MarketingBox.Postback.Service.Domain.Models;
using MarketingBox.Sdk.Common.Attributes;
using MarketingBox.Sdk.Common.Enums;
using MarketingBox.Sdk.Common.Models;
using CountryCodeType = MarketingBox.Sdk.Common.Enums.CountryCodeType;

namespace MarketingBox.Postback.Api.Models
{
    public class BrandPostbackRequestModel : ValidatableEntity
    {
        [Required]
        [AdvancedCompare(ComparisonType.GreaterThan, 0)]
        public long ClickId { get; set; }

        [Required] 
        [IsEnum] 
        public BrandEventType? EventType { get; set; }

        [Required]
        public GeneralInfoModel GeneralInfo { get; set; }

        [RequiredOnlyIf(nameof(EventType), BrandEventType.ChangedCrm)]
        [IsEnum]
        public CrmStatus? CrmStatus { get; set; }

        public AdditionalInfoModel AdditionalInfo { get; set; }

        public RegistrationBrandInfoModel RegistrationBrandInfo { get; set; }
    }

    public class GeneralInfoModel : ValidatableEntity
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
        [IsValidPassword]
        [StringLength(128, MinimumLength = 6)]
        [LogMasked(PreserveLength = true)]
        public string Password { get; set; }

        [Required]
        [IsValidEmail]
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string Email { get; set; }

        [Required]
        [Phone]
        [StringLength(20, MinimumLength = 7)]
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string Phone { get; set; }

        [Required]
        [RegularExpression(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$", ErrorMessage = "IP address has incorrect format.")]
        [LogMasked(PreserveLength = true, ShowFirst = 2, ShowLast = 2)]
        public string Ip { get; set; }

        [Required] 
        [IsEnum] 
        public CountryCodeType? CountryCodeType { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 2)]
        public string CountryCode { get; set; }
    }

    public class AdditionalInfoModel : ValidatableEntity
    {
        [StringLength(128, MinimumLength = 1)] public string Sub1 { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Sub2 { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Sub3 { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Sub4 { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Sub5 { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Sub6 { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Sub7 { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Sub8 { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Sub9 { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Sub10 { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Funnel { get; set; }
        [StringLength(128, MinimumLength = 1)] public string AffCode { get; set; }
    }

    public class RegistrationBrandInfoModel : ValidatableEntity
    {
        [StringLength(128, MinimumLength = 1)] public string CustomerId { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Token { get; set; }
        [StringLength(2500, MinimumLength = 1)] public string LoginUrl { get; set; }
        [StringLength(128, MinimumLength = 1)] public string Brand { get; set; }
    }
}