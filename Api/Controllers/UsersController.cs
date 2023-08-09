using Api.Data;
using Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DatingAppContext _context;
        public UsersController(DatingAppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<AppUser>>> GetAll()
        {
            var data= await _context.AppUsers.ToListAsync( );
            return data;
        }

    }
}
