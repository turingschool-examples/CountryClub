using CountryClubAPI.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CountryClubAPI.Models;

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
        [HttpPost]
        [Route("api/members")]
        public IActionResult CreateMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();

            return new JsonResult(member);

        }
        [Route("api/members/edit/{id:int}")]
        public IActionResult Edit(int id)
        {
            var members = _context.Members.Find(id);

            return new JsonResult(members);
        }

        [HttpPost]
        [Route("api/members/edit/{id:int}")]
        public IActionResult Update(Member member)
        {
            
            _context.Members.Update(member);
            _context.SaveChanges();

            return new JsonResult(member);
        }
    }
}
