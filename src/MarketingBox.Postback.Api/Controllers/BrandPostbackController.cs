using System;
using System.Threading.Tasks;
using AutoMapper;
using MarketingBox.Postback.Api.Models;
using MarketingBox.Postback.Service.Domain.Models.Requests;
using MarketingBox.Postback.Service.Grpc;
using MarketingBox.Sdk.Common.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace MarketingBox.Postback.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandPostbackController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBrandPostbackService _postbackService;

        public BrandPostbackController(IBrandPostbackService postbackService, IMapper mapper)
        {
            _postbackService = postbackService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> UpsertInfoFromBrand(
            [FromBody] BrandPostbackRequestModel brandPostbackRequestModel)
        {
            try
            {
                brandPostbackRequestModel.ValidateEntity();

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