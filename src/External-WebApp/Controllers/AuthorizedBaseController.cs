using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PSC.ExternalWebApp.Controllers
{
    [Authorize]
    public abstract class AuthorizedBaseController : Controller
    {

    }
}