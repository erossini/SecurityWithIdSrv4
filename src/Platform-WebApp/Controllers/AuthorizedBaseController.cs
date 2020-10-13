using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PSC.PortalWebApp.Controllers
{
    [Authorize]
    public abstract class AuthorizedBaseController : Controller { }
}