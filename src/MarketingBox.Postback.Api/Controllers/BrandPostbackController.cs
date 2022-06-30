using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using AutoMapper;
using MarketingBox.Affiliate.Service.Client.Interfaces;
using MarketingBox.Postback.Api.Models;
using MarketingBox.Postback.Service.Domain.Models.Requests;
using MarketingBox.Postback.Service.Grpc;
using MarketingBox.Sdk.Common.Exceptions;
using MarketingBox.Sdk.Common.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace MarketingBox.Postback.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandPostbackController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAffiliateClient _affiliateClient;
        private readonly IBrandPostbackService _postbackService;

        public BrandPostbackController(
            IBrandPostbackService postbackService,
            IMapper mapper,
            IAffiliateClient affiliateClient)
        {
            _postbackService = postbackService;
            _mapper = mapper;
            _affiliateClient = affiliateClient;
        }

        [HttpPost]
        public async Task<IActionResult> UpsertInfoFromBrand(
            [FromHeader, Required] string apiKey,
            [FromBody] BrandPostbackRequestModel brandPostbackRequestModel)
        {
            try
            {
                if (string.IsNullOrEmpty(apiKey))
                {
                    throw new BadRequestException("ApiKey is required");
                }

                brandPostbackRequestModel.ValidateEntity();

                await _affiliateClient.GetAffiliateByApiKey(apiKey);

                var request = _mapper.Map<BrandPostbackRequest>(brandPostbackRequestModel);
                var result = await _postbackService.ProcessRequestAsync(request);
                return this.ProcessResult(result);
            }
            catch (Exception e)
            {
                return e.Failed();
            }
        }
    }
}