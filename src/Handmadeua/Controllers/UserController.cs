using System.Threading.Tasks;
using Handmadeua.Core.Services;
using Handmadeua.Core.UIModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Handmadeua.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("create")]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody]UserRegistration model)
        {
            return new ObjectResult(await _userService.Register(model));
        }
    }
}
