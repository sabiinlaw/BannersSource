using Corrigo.BannersSource.API.Models;
using Corrigo.BannersSource.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Corrigo.BannersSource.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly IViewRender _viewRender;

        public BannersController(IViewRender viewRender)
        {
            _viewRender = viewRender;
        }

        [HttpGet("template")]
        [AllowAnonymous]
        public string GetBanner(string countryCode, string trades, string badges)
        {
            var bannerModel = new Banner()
            {
                CountryCode = "US",
                EnterpriseCompanyId = 1,
                EnterpriseCompanyName = "Test",
                UiCulture = "en-en",
                UserName = "corrigo-user",
                UserId = 1,
                Trades = null
            };

            return _viewRender.RenderAsync("BannerTemplate", bannerModel).Result;
        }
    }
}