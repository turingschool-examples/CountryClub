using CountryClubAPI.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryClubAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly CountryClubContext _context;

        public MembersController(CountryClubContext context)
        {
            _context = context;
        }
        [Route("api/members")]
        public IActionResult AllMembers()
        {
            var members = _context.Members;

            return new JsonResult(members);
        }
       [Route("api/members/{id:int}")]
        public IActionResult OneMember(int id)
        {
            var members = _context.Members.Find(id);
            
            return new JsonResult(members);
        }
    }
}
