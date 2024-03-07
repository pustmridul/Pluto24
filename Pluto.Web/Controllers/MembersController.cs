using Microsoft.AspNetCore.Mvc;
using Pluto.Application.Interface;

namespace Pluto.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private IMemberService _memberService;
        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _memberService.GetAll());
        }
    }
}
