using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MarketingBox.Postback.Api.Controllers
{
    [ApiController]
    [Route("/api")]
    public class BrandPostbackController : ControllerBase
    {
        [HttpGet("")]
        public async Task<ActionResult> UpsertInfoFromBrand()
        {
            return await Task.FromResult(new AcceptedResult());
        }
    }
}