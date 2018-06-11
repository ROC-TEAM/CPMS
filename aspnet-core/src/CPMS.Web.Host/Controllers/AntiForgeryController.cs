using Microsoft.AspNetCore.Antiforgery;
using CPMS.Controllers;

namespace CPMS.Web.Host.Controllers
{
    public class AntiForgeryController : CPMSControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
