using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Note.Api.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected int AppUserId
        {
            get
            {
                var claim = User.FindFirst("AppUserId");

                if (claim == null)
                    throw new UnauthorizedAccessException();

                return int.Parse(claim.Value);
            }
        }
        protected int CompanyId
        {
            get
            {
                var claim = User.FindFirst("CompanyId");

                if (claim == null)
                    throw new UnauthorizedAccessException();

                return int.Parse(claim.Value);
            }
        }
        protected int AppRoleId
        {
            get
            {
                var claim = User.FindFirst("AppRoleId");

                if (claim == null)
                    throw new UnauthorizedAccessException();

                return int.Parse(claim.Value);
            }
        }
        protected int FullName
        {
            get
            {
                var claim = User.FindFirst("FullName");

                if (claim == null)
                    throw new UnauthorizedAccessException();

                return int.Parse(claim.Value);
            }
        }
    }
}
